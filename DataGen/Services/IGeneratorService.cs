using CoreClasses.Services.Common;
using CoreControls.Data;

namespace DataGen.Services
{
	internal interface IGeneratorService
	{
		void BeginGeneratingMatrices(
			MatrixDimension firstMatrix, MatrixDimension secondMatrix, int maxElementValue,
			int numberOfFiles, string outputFolder,
			ServiceSuccessCallback successCallback, ServiceErrorCallback errorCallback);

		void BeginGeneratingSplineApproxData(
			int xStart, int xStop, double xStep, int yStart, int yStop, int k1Max, int kNMax,
			int variantCount, string targetFolder,
			ServiceSuccessCallback successCallback, ServiceErrorCallback errorCallback);
	}
}