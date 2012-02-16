using System;
using System.ComponentModel;
using System.Windows.Forms;
using Checker.Common;
using Checker.Presenters;
using Checker.Presenters.Impl;
using Checker.Properties;
using Checker.Views;
using CoreClasses.Services.Common;

namespace Checker.Controls
{
	public partial class PiCalculationCheckControl : UserControl, IPiCalculationCheckView
	{
		#region Fields

		private readonly IPiCalculationCheckPresenter presenter;

		#endregion Fields

		#region Properties

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ServiceLocator ServiceLocator
		{
			set { presenter.ServiceLocator = value; }
		}

		public Logger Logger
		{
			set { presenter.Logger = value; }
		}

		#endregion Properties

		#region Constructors

		public PiCalculationCheckControl()
		{
			InitializeComponent();
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
			{
				return;
			}

			presenter = new PiCalculationCheckPresenter(this);
		}

		#endregion Constructors

		#region IBaseControlView implementation

		void IBaseControlView.ShowError(string message)
		{
			MessageBox.Show(this, message, Resources.Error_MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		void IBaseControlView.SetWaitMode()
		{
			Enabled = false;
		}

		void IBaseControlView.SetNormalMode()
		{
			Enabled = true;
		}

		#endregion IBaseControlView implementation

		#region IPiCalculationCheckView implementation

		string IPiCalculationCheckView.CalculatedPiValue
		{
			get { return calculatedPiValueTextBox.Text; }
		}

		#endregion IPiCalculationCheckView implementation

		#region Event handlers

		private void checkButton_Click(object sender, EventArgs e)
		{
			presenter.OnCheck();
		}

		#endregion Event handlers
	}
}
