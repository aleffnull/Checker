using System;
using Checker.Common;
using Checker.Properties;
using Checker.Services;
using Checker.Views;

namespace Checker.Presenters.Impl
{
	internal class MatrixEqualityCheckPresenter : BaseControlPresenter<IMatrixEqualityCheckView>, IMatrixEqualityCheckPresenter
	{
		#region Properties

		public IMatrixService MatrixService
		{
			get { return ServiceLocator.Resolve<IMatrixService>(); }
		}

		#endregion Properties

		#region Constructors

		public MatrixEqualityCheckPresenter(IMatrixEqualityCheckView view)
			: base(view)
		{
			//
		}

		#endregion Constructors

		#region IMatrixEqualityCheckPresenter implementation

		public void OnCheck()
		{
			string firstMatrixFilePath = View.FirstMatrixFilePath;
			if (string.IsNullOrEmpty(firstMatrixFilePath))
			{
				View.ShowError(Resources.Error_SpecifyFirstMatrixFile);
				return;
			}

			string secondMatrixFilePath = View.SecondMatrixFilePath;
			if (string.IsNullOrEmpty(secondMatrixFilePath))
			{
				View.ShowError(Resources.Error_SpecifySecondMatrixFile);
				return;
			}

			View.SetWaitMode();
			MatrixService.BeginCheckingMatrixEquality(firstMatrixFilePath, secondMatrixFilePath, Logger,
			                                          CheckMatrixEqualitySuccessCallback, e => CheckMatrixEqualityErrorCallback(e, Logger));
		}

		#endregion IMatrixEqualityCheckPresenter implementation

		#region Service callbacks

		private void CheckMatrixEqualitySuccessCallback()
		{
			View.SetNormalMode();
		}

		private void CheckMatrixEqualityErrorCallback(Exception e, Logger logger)
		{
			logger(e.Message);
			View.SetNormalMode();
		}

		#endregion Service callbacks
	}
}