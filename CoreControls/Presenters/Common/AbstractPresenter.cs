namespace CoreControls.Presenters.Common
{
	public abstract class AbstractPresenter<TView>
	{
		#region Properties

		protected TView View { get; private set; }

		#endregion Properties

		#region Constructors

		protected AbstractPresenter(TView view)
		{
			View = view;
		}

		#endregion Constructors
	}
}