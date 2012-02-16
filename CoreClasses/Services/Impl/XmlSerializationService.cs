using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using CoreClasses.Services.Common;

namespace CoreClasses.Services.Impl
{
	public class XmlSerializationService : AbstractAsyncService, ISerializationService
	{
		#region ISerializationService implementation

		public void BeginSerializing(object obj, string filePath, ServiceSuccessCallback successCallback, ServiceErrorCallback errorCallback)
		{
			DoRequest(() => SaveToFile(obj, filePath), successCallback, errorCallback);
		}

		public void BeginDeserializing<T>(string filePath, ServiceSuccessCallback<T> successCallback, ServiceErrorCallback errorCallback)
		{
			DoRequest(() => LoadFromFile<T>(filePath), successCallback, errorCallback);
		}

		#endregion ISerializationService implementation

		#region Helpers

		private static void SaveToFile(object obj, string filePath)
		{
			XmlWriterSettings settings = new XmlWriterSettings {Encoding = Encoding.UTF8, Indent = true};
			using (Stream stream = File.OpenWrite(filePath))
			{
				XmlWriter writer = null;
				try
				{
					writer = XmlWriter.Create(stream, settings);
					XmlSerializer serializer = new XmlSerializer(obj.GetType());
					serializer.Serialize(writer, obj);
				}
				finally
				{
					if (writer != null)
					{
						writer.Close();
					}
				}
			}
		}

		private static T LoadFromFile<T>(string filePath)
		{
			using (Stream stream = File.OpenRead(filePath))
			{
				XmlSerializer serializer = new XmlSerializer(typeof (T));
				T obj = (T)serializer.Deserialize(stream);

				return obj;
			}
		}

		#endregion Helpers
	}
}