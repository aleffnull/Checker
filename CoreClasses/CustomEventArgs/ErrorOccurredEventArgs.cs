using System;

namespace CoreClasses.CustomEventArgs
{
	internal class ErrorOccurredEventArgs : EventArgs
	{
		#region Fields

		private readonly Exception exception;

		#endregion Fields

		#region Properties

		public Exception Exception
		{
			get { return exception; }
		}

		#endregion Properties

		#region Constructors

		public ErrorOccurredEventArgs(Exception exception)
		{
			this.exception = exception;
		}

		#endregion Constructors
	}
}