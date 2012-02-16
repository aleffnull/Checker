namespace Checker.Views
{
	internal interface IBaseControlView
	{
		void ShowError(string message);
		void SetWaitMode();
		void SetNormalMode();
	}
}