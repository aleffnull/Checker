using System;

namespace DataGen.CustomEventArgs
{
	internal class CompletedEventArgs : EventArgs
	{
		#region Fields

		private readonly object result;

		#endregion Fields

		#region Properties

		public object Result
		{
			get { return result; }
		}

		#endregion Properties

		#region Constructors

		public CompletedEventArgs(object result)
		{
			this.result = result;
		}

		#endregion Constructors
	}
}