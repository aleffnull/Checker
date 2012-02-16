namespace Checker.Views
{
	internal interface IMatrixMultiplicationCheckView : IBaseControlView
	{
		string InputFilePath { get; }
		string OutputFilePath { get; }
	}
}