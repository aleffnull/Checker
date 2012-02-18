namespace DataGen.Presenters
{
	internal interface ISplineApproxPresenter : IBaseControlPresenter
	{
		void OnLoad();
		void OnSave();
		void OnGenerate();
	}
}