using System;
using System.Collections.Generic;

namespace CoreClasses.Services.Common
{
	public class ServiceLocator
	{
		#region Fields

		private readonly Dictionary<Type, object> services = new Dictionary<Type, object>();

		#endregion Fields

		#region Methods

		public void RegisterService<T>(T serviceImplementation) where T : class
		{
			Type serviceType = typeof(T);
			if (services.ContainsKey(serviceType))
			{
				services[serviceType] = serviceImplementation;
			}
			else
			{
				services.Add(serviceType, serviceImplementation);
			}
		}

		public T Resolve<T>() where T : class
		{
			Type serviceType = typeof(T);
			T serviceImplementation = services.ContainsKey(serviceType)
			                          	? (T)services[serviceType]
			                          	: null;

			return serviceImplementation;
		}

		#endregion Methods
	}
}