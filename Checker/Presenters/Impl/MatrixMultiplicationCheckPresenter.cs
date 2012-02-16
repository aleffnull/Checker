using System;
using Checker.Common;
using Checker.Properties;
using Checker.Services;
using Checker.Views;

namespace Checker.Presenters.Impl
{
	internal class MatrixMultiplicationCheckPresenter : BaseControlPresenter<IMatrixMultiplicationCheckView>, IMatrixMultiplicationCheckPresenter
	{
		#region Properties

		public IMatrixService MatrixService
		{
			get { return ServiceLocator.Resolve<IMatrixService>(); }
		}

		#endregion Properties

		#region Constructors

		public MatrixMultiplicationCheckPresenter(IMatrixMultiplicationCheckView view)
			: base(view)
		{
			//
		}

		#endregion Constructors

		#region IMatrixMultiplicationCheckPresenter implementation

		public void OnCheck()
		{
			string inputFilePath = View.InputFilePath;
			if (string.IsNullOrEmpty(inputFilePath))
			{
				View.ShowError(Resources.Error_SpecifyInputFile);
				return;
			}

			string outputFilePath = View.OutputFilePath;
			if (string.IsNullOrEmpty(outputFilePath))
			{
				View.ShowError(Resources.Error_SpecifyOutputFile);
				return;
			}

			View.SetWaitMode();
			MatrixService.BeginCheckingMultiplicationResult(View.InputFilePath, View.OutputFilePath, Logger,
			                                                CheckMultiplicationResultSuccessCallback, e => CheckMultiplicationResultErrorCallback(e, Logger));
		}

		#endregion IMatrixMultiplicationCheckPresenter implementation

		#region Service callbacks

		private void CheckMultiplicationResultSuccessCallback()
		{
			View.SetNormalMode();
		}

		private void CheckMultiplicationResultErrorCallback(Exception e, Logger logger)
		{
			logger(e.Message);
			View.SetNormalMode();
		}

		#endregion Service callbacks
	}
}