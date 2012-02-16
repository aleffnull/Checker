using System.ComponentModel;
using System.Windows.Forms;
using CoreControls.Presenters;
using CoreControls.Presenters.Impl;
using CoreControls.Views;

namespace CoreControls.Controls
{
	public partial class BrowseForFileControl : UserControl, IBrowseForFileView
	{
		#region Fields

		private readonly IBrowseForFilePresenter presenter;

		#endregion Fields

		#region Properties

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string Path
		{
			get { return filePathTextBox.Text; }
		}

		[Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string Filter
		{
			get { return openFileDialog.Filter; }
			set { openFileDialog.Filter = value; }
		}

		[Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string DialogTitle
		{
			get { return openFileDialog.Title; }
			set { openFileDialog.Title = value; }
		}

		#endregion Properties

		#region Constructors

		public BrowseForFileControl()
		{
			InitializeComponent();
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
			{
				return;
			}

			presenter = new BrowseForFilePresenter(this);
		}

		#endregion Constructors

		#region IBrowseForFileView implementation

		string IBrowseForFileView.FilePath
		{
			set { filePathTextBox.Text = value; }
		}

		string IBrowseForFileView.AskForFile()
		{
			DialogResult dialogResult = openFileDialog.ShowDialog(this);
			return dialogResult == DialogResult.OK
			       	? openFileDialog.FileName
			       	: string.Empty;
		}

		#endregion IBrowseForFileView implementation

		#region Events handlers

		private void browseButton_Click(object sender, System.EventArgs e)
		{
			presenter.OnBrowse();
		}

		#endregion Events handlers
	}
}
