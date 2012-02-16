using System;
using System.Globalization;
using Checker.Common;
using Checker.Properties;
using Checker.Services;
using Checker.Views;

namespace Checker.Presenters.Impl
{
	internal class PiCalculationCheckPresenter : BaseControlPresenter<IPiCalculationCheckView>, IPiCalculationCheckPresenter
	{
		#region Properties

		private IMathService MathService
		{
			get { return ServiceLocator.Resolve<IMathService>(); }
		}

		#endregion Properties

		#region Constructors

		public PiCalculationCheckPresenter(IPiCalculationCheckView view)
			: base(view)
		{
			//
		}

		#endregion Constructors

		#region IPiCalculationCheckPresenter implementation

		public void OnCheck()
		{
			string calculatedPi = View.CalculatedPiValue;
			if (string.IsNullOrEmpty(calculatedPi))
			{
				View.ShowError(Resources.Error_SpecifyPiValue);
				return;
			}

			double pi;
			bool parseResult = double.TryParse(calculatedPi, out pi) ||
			                   double.TryParse(calculatedPi, NumberStyles.Any, CultureInfo.InvariantCulture, out pi);
			if (!parseResult)
			{
				View.ShowError(Resources.Error_CalculatedPiInNotANumber);
				return;
			}

			View.SetWaitMode();
			MathService.BeginCheckingNumbersEquality(
				calculatedPi, Resources.MasterValue_Pi, Logger,
				CheckNumbersEqualitySuccessCallback, e => CheckNumbersEqualityErrorCallback(e, Logger));
		}

		#endregion IPiCalculationCheckPresenter implementation

		#region Service callbacks

		private void CheckNumbersEqualitySuccessCallback()
		{
			View.SetNormalMode();
		}

		private void CheckNumbersEqualityErrorCallback(Exception e, Logger logger)
		{
			logger(e.Message);
			View.SetNormalMode();
		}

		#endregion Service callbacks
	}
}