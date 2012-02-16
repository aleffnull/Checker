using Checker.Common;
using CoreClasses.Services.Common;
using CoreControls.Presenters.Common;

namespace Checker.Presenters.Impl
{
	internal abstract class BaseControlPresenter<TView> : AbstractPresenter<TView>, IBaseControlPresenter
	{
		#region IBaseControlPresenter implementation

		public ServiceLocator ServiceLocator { protected get; set; }

		public Logger Logger { protected get; set; }

		#endregion IBaseControlPresenter implementation

		#region Constructors

		protected BaseControlPresenter(TView view)
			: base(view)
		{
			//
		}

		#endregion Constructors
	}
}