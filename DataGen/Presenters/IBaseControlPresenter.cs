using CoreClasses.Services.Common;

namespace DataGen.Presenters
{
	internal interface IBaseControlPresenter
	{
		ServiceLocator ServiceLocator { set; }
	}
}