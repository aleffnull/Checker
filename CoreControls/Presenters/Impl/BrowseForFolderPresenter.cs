using CoreControls.Presenters.Common;
using CoreControls.Views;

namespace CoreControls.Presenters.Impl
{
	internal class BrowseForFolderPresenter : AbstractPresenter<IBrowseForFolderView>, IBrowseForFolderPresenter
	{
		#region Constructors

		public BrowseForFolderPresenter(IBrowseForFolderView view)
			: base(view)
		{
			//
		}

		#endregion Constructors

		#region IBrowseForFolderPresenter implementation

		public void OnBrowse()
		{
			string folderPath = View.AskForFolder();
			if (string.IsNullOrEmpty(folderPath))
			{
				return;
			}

			View.FolderPath = folderPath;
		}

		#endregion IBrowseForFolderPresenter implementation
	}
}