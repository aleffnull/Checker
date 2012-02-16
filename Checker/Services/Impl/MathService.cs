using Checker.Common;
using CoreClasses.Services.Common;

namespace Checker.Services.Impl
{
	internal class MathService : AbstractAsyncService, IMathService
	{
		#region Constants

		private static readonly char[] SEPARATORS = {',', '.'};

		#endregion Constants

		#region IMathService implementation

		public void BeginCheckingNumbersEquality(
			string calculatedValue, string masterValue, Logger logger, ServiceSuccessCallback successCallback, ServiceErrorCallback errorCallback)
		{
			DoRequest(() => CheckNumbersEquality(calculatedValue, masterValue, logger), successCallback, errorCallback);
		}

		#endregion IMathService implementation

		#region Helpers

		private void CheckNumbersEquality(string calculatedValue, string masterValue, Logger logger)
		{
			logger("Checking numbers equality");

			string[] calculatedParts = calculatedValue.Split(SEPARATORS);
			if (calculatedParts.Length != 2)
			{
				logger("Invalid format of calculated value");
				return;
			}

			string[] masterParts = masterValue.Split(SEPARATORS);
			if (masterParts.Length != 2)
			{
				logger("Invalid format of master value");
				return;
			}

			bool integersAreEqual = masterParts[0].Equals(calculatedParts[0]);
			if (!integersAreEqual)
			{
				logger("Integer parts are not equal");
				return;
			}

			string calculatedFraction = calculatedParts[1];
			string masterFraction = masterParts[1];

			int length;
			if (calculatedFraction.Length < masterFraction.Length)
			{
				logger("Fractional part of calculated value is too short");
				length = calculatedFraction.Length;
			}
			else if ( calculatedFraction.Length > masterFraction.Length)
			{
				logger("Fractional part of calculated value is too long");
				length = masterFraction.Length;
			}
			else
			{
				length = masterFraction.Length;
			}

			for (int i = 0; i < length; i++)
			{
				bool equal = masterFraction[i].Equals(calculatedFraction[i]);
				if (!equal)
				{
					logger(string.Format("Fractional parts are not equal, error in {0} digit after point", i + 1));
					return;
				}
			}

			logger("Numbers are equal");
		}

		#endregion Helpers
	}
}