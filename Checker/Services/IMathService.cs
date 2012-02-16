using Checker.Common;
using CoreClasses.Services.Common;

namespace Checker.Services
{
	internal interface IMathService
	{
		void BeginCheckingNumbersEquality(
			string calculatedValue, string masterValue, Logger logger, ServiceSuccessCallback successCallback, ServiceErrorCallback errorCallback);
	}
}