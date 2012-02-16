using System;
using System.ComponentModel;
using System.Windows.Forms;
using CoreControls.Presenters;
using CoreControls.Presenters.Impl;
using CoreControls.Views;

namespace CoreControls.Controls
{
	public partial class BrowseForFolderControl : UserControl, IBrowseForFolderView
	{
		#region Fields

		private readonly IBrowseForFolderPresenter presenter;

		#endregion Fields

		#region Properties

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string Path
		{
			get { return folderPathTextBox.Text; }
			set { folderPathTextBox.Text = value; }
		}

		[Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string DialogTitle
		{
			get { return folderBrowserDialog.Description; }
			set { folderBrowserDialog.Description = value; }
		}

		#endregion Properties

		#region Constructors

		public BrowseForFolderControl()
		{
			InitializeComponent();
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
			{
				return;
			}

			presenter = new BrowseForFolderPresenter(this);
		}

		#endregion Constructors

		#region IBrowseForFolderView implementation

		string IBrowseForFolderView.FolderPath
		{
			set { folderPathTextBox.Text = value; }
		}

		string IBrowseForFolderView.AskForFolder()
		{
			DialogResult dialogResult = folderBrowserDialog.ShowDialog(this);
			return dialogResult == DialogResult.OK
			       	? folderBrowserDialog.SelectedPath
			       	: string.Empty;
		}

		#endregion IBrowseForFolderView implementation

		#region Event handlers

		private void browseButton_Click(object sender, EventArgs e)
		{
			presenter.OnBrowse();
		}

		#endregion Event handlers
	}
}
