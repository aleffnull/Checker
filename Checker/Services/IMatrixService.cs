using Checker.Common;
using CoreClasses.Services.Common;

namespace Checker.Services
{
	internal interface IMatrixService
	{
		void BeginCheckingMultiplicationResult(string inputFilePath, string outputFilePath, Logger logger,
		                                       ServiceSuccessCallback successCallback, ServiceErrorCallback errorCallback);

		void BeginCheckingMatrixEquality(string firstMatrixFilePath, string secondMatrixFilePath, Logger logger,
		                                 ServiceSuccessCallback successCallback, ServiceErrorCallback errorCallback);
	}
}