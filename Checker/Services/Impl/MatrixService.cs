using Checker.Common;
using CoreClasses.Services.Common;
using MathClasses.Classes;
using MathClasses.Services;

namespace Checker.Services.Impl
{
	internal class MatrixService : AbstractAsyncService, IMatrixService
	{
		#region Fields

		private readonly ServiceLocator serviceLocator;

		#endregion Fields

		#region Properties

		public IMatrixAlgorithmsService MatrixAlgorithmsService
		{
			get { return serviceLocator.Resolve<IMatrixAlgorithmsService>(); }
		}

		#endregion Properties

		#region Constructors

		public MatrixService(ServiceLocator serviceLocator)
		{
			this.serviceLocator = serviceLocator;
		}

		#endregion Constructors

		#region IMatrixService implementation

		public void BeginCheckingMultiplicationResult(string inputFilePath, string outputFilePath, Logger logger,
		                                              ServiceSuccessCallback successCallback, ServiceErrorCallback errorCallback)
		{
			DoRequest(() => CheckMultiplicationResult(inputFilePath, outputFilePath, logger), successCallback, errorCallback);
		}

		public void BeginCheckingMatrixEquality(string firstMatrixFilePath, string secondMatrixFilePath, Logger logger,
		                                        ServiceSuccessCallback successCallback, ServiceErrorCallback errorCallback)
		{
			DoRequest(() => CheckMatrixEquality(firstMatrixFilePath, secondMatrixFilePath, logger), successCallback, errorCallback);
		}

		#endregion IMatrixService implementation

		#region Helpers

		private void CheckMultiplicationResult(string inputFilePath, string outputFilePath, Logger logger)
		{
			logger("Checking multiplication result");

			Matrix firstMatrix = new Matrix();
			Matrix secondMatrix = new Matrix();

			logger(string.Format("Loading input matrices from '{0}'.", inputFilePath));
			MatrixAlgorithmsService.LoadMatrices(inputFilePath, firstMatrix, secondMatrix);
			if (!firstMatrix.IsValid)
			{
				logger("First matrix is invalid!");
				return;
			}
			if (!secondMatrix.IsValid)
			{
				logger("Second matrix is invalid");
				return;
			}

			logger(string.Format("Loading calculated matrix from '{0}'.", outputFilePath));
			Matrix calculatedMatrix = MatrixAlgorithmsService.LoadMatrix(outputFilePath);
			if (!calculatedMatrix.IsValid)
			{
				logger("Calculated matrix is invalid");
				return;
			}

			logger("Calculating master result");
			Matrix masterMatrix = MatrixAlgorithmsService.SimpleMultiplication(firstMatrix, secondMatrix);

			logger("Checking dimensions");
			if (masterMatrix.RowCount != calculatedMatrix.RowCount || masterMatrix.ColumnCount != calculatedMatrix.ColumnCount)
			{
				logger("Dimensions of calculated and master matrix are different");
				return;
			}

			logger("Checking elements equality");
			bool equal = masterMatrix.IsEqualTo(calculatedMatrix);
			logger(equal ? "OK: matrices are equal" : "Failed: matrices are NOT equal");
		}

		private void CheckMatrixEquality(string firstMatrixFilePath, string secondMatrixFilePath, Logger logger)
		{
			logger("Checking matrices equality");

			logger(string.Format("Loading first matrix from '{0}'", firstMatrixFilePath));
			Matrix firstMatrix = MatrixAlgorithmsService.LoadMatrix(firstMatrixFilePath);

			logger(string.Format("Loading second matrix from '{0}'", secondMatrixFilePath));
			Matrix secondMatrix = MatrixAlgorithmsService.LoadMatrix(secondMatrixFilePath);

			if (!firstMatrix.IsValid)
			{
				logger("First matrix is invalid!");
				return;
			}
			if (!secondMatrix.IsValid)
			{
				logger("Second matrix is invalid");
				return;
			}

			logger("Checking dimensions");
			if (firstMatrix.RowCount != secondMatrix.RowCount || firstMatrix.ColumnCount != secondMatrix.ColumnCount)
			{
				logger("Dimensions of first and second matrix are different");
				return;
			}

			logger("Checking elements equality");
			bool equal = firstMatrix.IsEqualTo(secondMatrix);
			logger(equal ? "OK: matrices are equal" : "Failed: matrices are NOT equal");
		}

		#endregion Helpers
	}
}