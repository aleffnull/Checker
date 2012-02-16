using CoreControls.Presenters.Common;
using CoreControls.Views;

namespace CoreControls.Presenters.Impl
{
	internal class BrowseForFilePresenter : AbstractPresenter<IBrowseForFileView>, IBrowseForFilePresenter
	{
		#region Constructors

		public BrowseForFilePresenter(IBrowseForFileView view)
			: base(view)
		{
			//
		}

		#endregion Constructors

		#region IBrowseForFilePresenter implementation

		public void OnBrowse()
		{
			string filePath = View.AskForFile();
			if (string.IsNullOrEmpty(filePath))
			{
				return;
			}

			View.FilePath = filePath;
		}

		#endregion IBrowseForFilePresenter implementation
	}
}