using System.Xml.Serialization;

namespace DataGen.Models
{
	[XmlRoot("SplineApproximation")]
	public class SplineApproxModel
	{
		#region Properties

		public int XStart { get; set; }
		public int XStop { get; set; }
		public double XStep { get; set; }

		public int YStart { get; set; }
		public int YStop { get; set; }

		public int K1Max { get; set; }
		public int KnMax { get; set; }
		public int VariantsCount { get; set; }

		public string TargetFolder { get; set; }

		#endregion Properties

		#region Constructors

		public SplineApproxModel(
			int xStart, int xStop, double xStep, int yStart, int yStop, int k1Max, int kNMax, int variantsCount, string targetFolder)
		{
			XStart = xStart;
			XStop = xStop;
			XStep = xStep;
			YStart = yStart;
			YStop = yStop;
			K1Max = k1Max;
			KnMax = kNMax;
			VariantsCount = variantsCount;
			TargetFolder = targetFolder;
		}

		public SplineApproxModel()
		{
			//
		}

		#endregion Constructors
	}
}