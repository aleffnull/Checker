using System;
using System.ComponentModel;
using System.Windows.Forms;
using CoreClasses.Services.Common;
using DataGen.Presenters;
using DataGen.Presenters.Impl;
using DataGen.Properties;
using DataGen.Views;

namespace DataGen.Controls
{
	public partial class SplineApproxControl : UserControl, ISplineApproxView
	{
		#region Fields

		private readonly ISplineApproxPresenter presenter;

		#endregion Fields

		#region Properties

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ServiceLocator ServiceLocator
		{
			set { presenter.ServiceLocator = value; }
		}

		#endregion Properties

		#region Constructors

		public SplineApproxControl()
		{
			InitializeComponent();
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
			{
				return;
			}

			presenter = new SplineApproxPresenter(this);
		}

		#endregion Constructors

		#region ISplineApproxView implementation

		#region Properties

		public int XStart
		{
			get { return (int)xFromNumericUpDown.Value; }
			set { xFromNumericUpDown.Value = value; }
		}

		public int XStop
		{
			get { return (int)xToNumericUpDown.Value; }
			set { xToNumericUpDown.Value = value; }
		}

		public double XStep
		{
			get { return (double)xStepNumericUpDown.Value; }
			set { xStepNumericUpDown.Value = new decimal(value); }
		}

		public int YStart
		{
			get { return (int)yFromNumericUpDown.Value; }
			set { yFromNumericUpDown.Value = value; }
		}

		public int YStop
		{
			get { return (int)yToNumericUpDown.Value; }
			set { yToNumericUpDown.Value = value; }
		}

		public int K1Max
		{
			get { return (int)k1MaxNumericUpDown.Value; }
			set { k1MaxNumericUpDown.Value = value; }
		}

		public int KnMax
		{
			get { return (int)kNMAxNumericUpDown.Value; }
			set { kNMAxNumericUpDown.Value = value; }
		}

		public int VariantsCount
		{
			get { return (int)variantsCountNumericUpDown.Value; }
			set { variantsCountNumericUpDown.Value = value; }
		}

		public string TargetFolder
		{
			get { return targetFolderBrowseControl.Path; }
			set { targetFolderBrowseControl.Path = value; }
		}

		#endregion Properties

		#region Methods

		string ISplineApproxView.AskForProfileLoadPath()
		{
			loadProfileDialog.FileName = string.Empty;
			DialogResult dialogResult = loadProfileDialog.ShowDialog(this);
			return dialogResult == DialogResult.OK
			       	? loadProfileDialog.FileName
			       	: string.Empty;
		}

		string ISplineApproxView.AskForProfileSavePath()
		{
			saveProfileDialog.FileName = string.Empty;
			DialogResult dialogResult = saveProfileDialog.ShowDialog(this);
			return dialogResult == DialogResult.OK
			       	? saveProfileDialog.FileName
			       	: string.Empty;
		}

		void ISplineApproxView.SetWaitMode()
		{
			Enabled = false;
		}

		void ISplineApproxView.SetNormalMode()
		{
			Enabled = true;
		}

		void ISplineApproxView.ShowError(string message)
		{
			MessageBox.Show(this, message, Resources.Text_ErrorMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		#endregion Methods

		#endregion ISplineApproxView implementation

		#region Event handlers

		private void loadButton_Click(object sender, EventArgs e)
		{
			presenter.OnLoad();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			presenter.OnSave();
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			presenter.OnGenerate();
		}

		#endregion Event handlers

	}
}
