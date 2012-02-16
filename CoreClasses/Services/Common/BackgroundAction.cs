using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using CoreClasses.CustomEventArgs;

namespace CoreClasses.Services.Common
{
	internal class BackgroundAction
	{
		#region Fields

		private readonly SynchronizationContext syncContext;
		private readonly Thread thread;

		#endregion Fields

		#region Events

		public event EventHandler<CompletedEventArgs> Completed;
		public event EventHandler<ErrorOccurredEventArgs> ErrorOccurred;

		#endregion Events

		#region Constructors

		public BackgroundAction(ActionPerformer actionPerformer)
		{
			syncContext = SynchronizationContext.Current;
			thread = new Thread(state => RunWorker(actionPerformer)) {IsBackground = true};
		}

		#endregion Constructors

		#region Methods

		public void Perform()
		{
			thread.Start();
		}

		#endregion Methods

		#region Helpers

		private void RunWorker(ActionPerformer actionPerformer)
		{
			try
			{
				ActionArgs args = new ActionArgs();
				actionPerformer(args);
				Post(state => OnCompleted(args.Result));
			}
			catch (Exception e)
			{
				Post(state => OnErrorOccurred(e));
			}
		}

		private void Post(SendOrPostCallback callback)
		{
			if (syncContext != null && SyncContextIsValid())
			{
				syncContext.Post(callback, null);
			}
			else
			{
				callback(null);
			}
		}

		private bool SyncContextIsValid()
		{
			if (syncContext is WindowsFormsSynchronizationContext)
			{
				FieldInfo info = syncContext.GetType().GetField("controlToSendTo", BindingFlags.NonPublic | BindingFlags.Instance);
				if (info != null)
				{
					Control controlToSendTo = (Control)info.GetValue(syncContext);
					if (controlToSendTo != null)
					{
						if (controlToSendTo.IsDisposed || controlToSendTo.Disposing)
						{
							return false;
						}
					}
				}
			}

			return true;
		}

		private void OnCompleted(object result)
		{
			EventHandler<CompletedEventArgs> eventHandler = Completed;
			if (eventHandler != null)
			{
				CompletedEventArgs eventArgs = new CompletedEventArgs(result);
				eventHandler(this, eventArgs);
			}
		}

		private void OnErrorOccurred(Exception exception)
		{
			EventHandler<ErrorOccurredEventArgs> eventHandler = ErrorOccurred;
			if (eventHandler != null)
			{
				ErrorOccurredEventArgs eventArgs = new ErrorOccurredEventArgs(exception);
				eventHandler(this, eventArgs);
			}
		}

		#endregion Helpers
	}
}