using CoreControls.Data;

namespace DataGen.Views
{
	internal interface IMatrixMultiplicationView
	{
		MatrixDimension FirstMatrixDimension { get; set; }
		MatrixDimension SecondMatrixDimension { get; set; }
		int MaxEvementValue { get; set; }
		int NumberOfFiles { get; set; }
		string OutputFolder { get; set; }

		string AskForProfileLoadPath();
		string AskForProfileSavePath();

		void SetWaitMode();
		void SetNormalMode();
		void ShowError(string message);
	}
}