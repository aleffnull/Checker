using System.Xml.Serialization;
using CoreControls.Data;

namespace DataGen.Models
{
	[XmlRoot("MatrixGeneration")]
	public class GenerateMatricesModel
	{
		#region Properties

		public MatrixDimension FirstMatrixDimension { get; set; }
		public MatrixDimension SecondMatrixDimension { get; set; }
		public int MaxEvementValue { get; set; }
		public int NumberOfFiles { get; set; }
		public string OutputFolder { get; set; }

		#endregion Properties

		#region Constructors

		public GenerateMatricesModel()
		{
			//
		}

		public GenerateMatricesModel(
			MatrixDimension firstMatrixDimension, MatrixDimension secondMatrixDimension,
			int maxEvementValue, int numberOfFiles, string outputFolder)
		{
			FirstMatrixDimension = firstMatrixDimension;
			SecondMatrixDimension = secondMatrixDimension;
			MaxEvementValue = maxEvementValue;
			NumberOfFiles = numberOfFiles;
			OutputFolder = outputFolder;
		}

		#endregion Constructors
	}
}