using Checker.Common;
using CoreClasses.Services.Common;

namespace Checker.Presenters
{
	internal interface IBaseControlPresenter
	{
		ServiceLocator ServiceLocator { set; }
		Logger Logger { set; }
	}
}