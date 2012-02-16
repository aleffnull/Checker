namespace CoreControls.Views
{
	internal interface IBrowseForFileView
	{
		string FilePath { set; }
		string AskForFile();
	}
}