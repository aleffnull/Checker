using System;

namespace CoreClasses.CustomEventArgs
{
	internal class CompletedEventArgs : EventArgs
	{
		#region Properties

		public object Result { get; private set; }

		#endregion Properties

		#region Constructors

		public CompletedEventArgs(object result)
		{
			Result = result;
		}

		#endregion Constructors
	}
}