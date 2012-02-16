namespace Checker.Views
{
	internal interface IMatrixEqualityCheckView : IBaseControlView
	{
		string FirstMatrixFilePath { get; }
		string SecondMatrixFilePath { get; }
	}
}