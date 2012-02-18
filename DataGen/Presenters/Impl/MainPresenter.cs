using CoreClasses.Services;
using CoreClasses.Services.Common;
using CoreClasses.Services.Impl;
using CoreControls.Presenters.Common;
using DataGen.Services;
using DataGen.Services.Impl;
using DataGen.Views;

namespace DataGen.Presenters.Impl
{
	internal class MainPresenter : AbstractPresenter<IMainView>, IMainPresenter
	{
		#region Constructors

		public MainPresenter(IMainView view)
			: base(view)
		{
			//
		}

		#endregion Constructors

		#region IMainPresenter implementation

		public void OnLoad()
		{
			View.ServiceLocator = CreateServiceLocator();
		}

		#endregion IMainPresenter implementation

		#region Helpers

		private static ServiceLocator CreateServiceLocator()
		{
			ServiceLocator serviceLocator = new ServiceLocator();
			serviceLocator.RegisterService<IGeneratorService>(new GeneratorService());
			serviceLocator.RegisterService<ISerializationService>(new XmlSerializationService());

			return serviceLocator;
		}

		#endregion Helpers
	}
}