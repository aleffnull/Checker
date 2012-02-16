using CoreClasses.Services.Common;

namespace CoreClasses.Services
{
	public interface ISerializationService
	{
		void BeginSerializing(object obj, string filePath, ServiceSuccessCallback successCallback, ServiceErrorCallback errorCallback);
		void BeginDeserializing<T>(string filePath, ServiceSuccessCallback<T> successCallback, ServiceErrorCallback errorCallback);
	}
}