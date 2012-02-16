namespace CoreControls.Views
{
	internal interface IBrowseForFolderView
	{
		string FolderPath { set; }
		string AskForFolder();
	}
}