using CoreClasses.Services.Common;

namespace DataGen.Presenters
{
	internal interface IMatrixMultiplicationPresenter : IBaseControlPresenter
	{
		void OnLoadProfile();
		void OnSaveProfile();
		void OnGenerate();
	}
}