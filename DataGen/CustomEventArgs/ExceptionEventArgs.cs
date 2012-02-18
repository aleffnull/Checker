using System;

namespace DataGen.CustomEventArgs
{
	internal class ExceptionEventArgs : EventArgs
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

		public ExceptionEventArgs(Exception exception)
		{
			this.exception = exception;
		}

		#endregion Constructors
	}
}