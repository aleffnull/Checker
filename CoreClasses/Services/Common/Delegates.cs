using System;

namespace CoreClasses.Services.Common
{
	public delegate void ServiceWorker();
	public delegate T ServiceWorker<T>();
	public delegate void ServiceSuccessCallback();
	public delegate void ServiceSuccessCallback<T>(T result);
	public delegate void ServiceErrorCallback(Exception e);
}