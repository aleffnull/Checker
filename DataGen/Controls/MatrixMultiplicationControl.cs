using System;
using System.ComponentModel;
using System.Windows.Forms;
using CoreClasses.Services.Common;
using CoreControls.Data;
using DataGen.Presenters;
using DataGen.Presenters.Impl;
using DataGen.Properties;
using DataGen.Views;

namespace DataGen.Controls
{
	public partial class MatrixMultiplicationControl : UserControl, IMatrixMultiplicationView
	{
		#region Fields

		private readonly IMatrixMultiplicationPresenter presenter;

		#endregion Fields

		#region Properties

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ServiceLocator ServiceLocator
		{
			set { presenter.ServiceLocator = value; }
		}

		#endregion Properties

		#region Constructors

		public MatrixMultiplicationControl()
		{
			InitializeComponent();
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
			{
				return;
			}

			presenter = new MatrixMultiplicationPresenter(this);
		}

		#endregion Constructors

		#region IMatrixMultiplicationView implementation

		#region Properties

		MatrixDimension IMatrixMultiplicationView.FirstMatrixDimension
		{
			get { return firstMatrixDimensionControl.MatrixDimension; }
			set { firstMatrixDimensionControl.MatrixDimension = value; }
		}

		MatrixDimension IMatrixMultiplicationView.SecondMatrixDimension
		{
			get { return secondMatrixDimensionControl.MatrixDimension; }
			set { secondMatrixDimensionControl.MatrixDimension = value; }
		}

		int IMatrixMultiplicationView.MaxEvementValue
		{
			get { return (int)maxElementValueNumericUpDown.Value; }
			set { maxElementValueNumericUpDown.Value = value; }
		}

		int IMatrixMultiplicationView.NumberOfFiles
		{
			get { return (int)numberOfFilesNumericUpDown.Value; }
			set { numberOfFilesNumericUpDown.Value = value; }
		}

		string IMatrixMultiplicationView.OutputFolder
		{
			get { return browseForFolderControl.Path; }
			set { browseForFolderControl.Path = value; }
		}

		#endregion Properties

		string IMatrixMultiplicationView.AskForProfileLoadPath()
		{
			loadProfileDialog.FileName = string.Empty;
			DialogResult dialogResult = loadProfileDialog.ShowDialog(this);
			return dialogResult == DialogResult.OK
			       	? loadProfileDialog.FileName
			       	: string.Empty;
		}

		string IMatrixMultiplicationView.AskForProfileSavePath()
		{
			saveProfileDialog.FileName = string.Empty;
			DialogResult dialogResult = saveProfileDialog.ShowDialog(this);
			return dialogResult == DialogResult.OK
			       	? saveProfileDialog.FileName
			       	: string.Empty;
		}

		void IMatrixMultiplicationView.SetWaitMode()
		{
			Enabled = false;
		}

		void IMatrixMultiplicationView.SetNormalMode()
		{
			Enabled = true;
		}

		void IMatrixMultiplicationView.ShowError(string message)
		{
			MessageBox.Show(this, message, Resources.Text_ErrorMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		#endregion IMatrixMultiplicationView implementation

		#region Event handlers

		private void loadProfileButton_Click(object sender, EventArgs e)
		{
			presenter.OnLoadProfile();
		}

		private void saveProfileButton_Click(object sender, EventArgs e)
		{
			presenter.OnSaveProfile();
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			presenter.OnGenerate();
		}

		#endregion Event handlers
	}
}
