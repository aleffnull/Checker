using CoreClasses.Services.Common;
using CoreControls.Presenters.Common;

namespace DataGen.Presenters.Impl
{
	internal abstract class BaseControlPresenter<TView> : AbstractPresenter<TView>, IBaseControlPresenter
	{
		#region Constructors

		protected BaseControlPresenter(TView view)
			: base(view)
		{
			//
		}

		#endregion Constructors

		#region IBaseControlPresenter implementation

		public ServiceLocator ServiceLocator { protected get; set; }

		#endregion IBaseControlPresenter implementation
	}
}