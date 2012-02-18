namespace DataGen.Views
{
	internal interface ISplineApproxView
	{
		int XStart { get; set; }
		int XStop { get; set; }
		double XStep { get; set; }

		int YStart { get; set; }
		int YStop { get; set; }

		int K1Max { get; set; }
		int KnMax { get; set; }
		int VariantsCount { get; set; }

		string TargetFolder {get; set; }

		string AskForProfileLoadPath();
		string AskForProfileSavePath();

		void SetWaitMode();
		void SetNormalMode();
		void ShowError(string message);
	}
}