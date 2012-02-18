using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CoreClasses.Services.Common;
using CoreControls.Data;
using DataGen.Common;

namespace DataGen.Services.Impl
{
	internal class GeneratorService : AbstractAsyncService, IGeneratorService
	{
		#region Constants

		private const string K_FILENAME = "k.txt";
		private const string DATA_FILENAME = "data.txt";

		#endregion Constants

		#region Fields

		private readonly Random random = new Random();

		#endregion Fields

		#region IGeneratorService implementation

		public void BeginGeneratingMatrices(
			MatrixDimension firstMatrix, MatrixDimension secondMatrix, int maxElementValue,
			int numberOfFiles, string outputFolder,
			ServiceSuccessCallback successCallback, ServiceErrorCallback errorCallback)
		{
			DoRequest(
				() => GenerateMatrices(firstMatrix, secondMatrix, maxElementValue, numberOfFiles, outputFolder),
				successCallback, errorCallback);
		}

		public void BeginGeneratingSplineApproxData(
			int xStart, int xStop, double xStep, int yStart, int yStop, int k1Max, int kNMax,
			int variantCount, string targetFolder,
			ServiceSuccessCallback successCallback, ServiceErrorCallback errorCallback)
		{
			DoRequest(
				() => GenerateSplineApproxData(xStart, xStop, xStep, yStart, yStop, k1Max, kNMax, variantCount, targetFolder),
				successCallback, errorCallback);
		}

		#endregion IGeneratorService implementation

		#region Helpers

		#region Matrix

		private void GenerateMatrices(
			MatrixDimension firstMatrix, MatrixDimension secondMatrix, int maxElementValue,
			int numberOfFiles, string outputFolder)
		{
			for (int fileIndex = 0; fileIndex < numberOfFiles; fileIndex++)
			{
				string fileName = string.Format("{0}.txt", fileIndex);
				string fullFileName = Path.Combine(outputFolder, fileName);
				GenerateFile(fullFileName, firstMatrix, secondMatrix, maxElementValue);
			}
		}

		private void GenerateFile(string fileName, MatrixDimension firstMatrix, MatrixDimension secondMatrix, int maxElementValue)
		{
			using (StreamWriter streamWriter = File.CreateText(fileName))
			{
				string matrixText = GenerateMatrix(firstMatrix, maxElementValue);
				streamWriter.Write(matrixText);
				streamWriter.Write(Environment.NewLine);

				matrixText = GenerateMatrix(secondMatrix, maxElementValue);
				streamWriter.Write(matrixText);
			}
		}

		private string GenerateMatrix(MatrixDimension matrixDimension, int maxElementValue)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int rowIndex = 0; rowIndex < matrixDimension.RowCount; rowIndex++)
			{
				List<string> rowList = new List<string>();
				for (int columnIndex = 0; columnIndex < matrixDimension.ColumnCount; columnIndex++)
				{
					int number = random.Next(maxElementValue + 1);
					rowList.Add(number.ToString());
				}
				string rowString = string.Join(Constants.Separator, rowList.ToArray());
				stringBuilder.AppendFormat("{0}{1}", rowString, Environment.NewLine);
			}

			return stringBuilder.ToString();
		}

		#endregion Matrix

		#region Spline approximation

		private void GenerateSplineApproxData(
			int xStart, int xStop, double xStep, int yStart, int yStop, int k1Max, int kNMax,
			int variantCount, string targetFolder)
		{
			for (int variantIndex = 0; variantIndex < variantCount; variantIndex++)
			{
				int variantNumber = variantIndex + 1;
				string folderName = variantNumber.ToString();
				string fullFolderPath = Path.Combine(targetFolder, folderName);

				EnsureFolderExistence(fullFolderPath);
				GenerateSplineApproxVariant(xStart, xStop, xStep, yStart, yStop, k1Max, kNMax, fullFolderPath);
			}
		}

		private void GenerateSplineApproxVariant(int xStart, int xStop, double xStep, int yStart, int yStop, int k1Max, int kNMax, string folderPath)
		{
			string kFilePath = Path.Combine(folderPath, K_FILENAME);
			GenerateK(k1Max, kNMax, kFilePath);

			string dataFilePath = Path.Combine(folderPath, DATA_FILENAME);
			GenerateData(xStart, xStop, xStep, yStart, yStop, dataFilePath);
		}

		private void GenerateK(int k1Max, int kNMax, string filePath)
		{
			int k1 = GenerateRandomNumber(-k1Max, k1Max);
			int kN = GenerateRandomNumber(-kNMax, kNMax);

			using (StreamWriter streamWriter = File.CreateText(filePath))
			{
				streamWriter.WriteLine(string.Format("K1 = {0}", k1));
				streamWriter.WriteLine(string.Format("Kn = {0}", kN));
			}
		}

		private void GenerateData(int xStart, int xStop, double xStep, int yStart, int yStop, string filePath)
		{
			using (StreamWriter streamWriter = File.CreateText(filePath))
			{
				double x = xStart;
				while (Math.Ceiling(x) <= xStop)
				{
					int y = GenerateRandomNumber(yStart, yStop);
					string line = string.Format("{0};{1}", x, y);
					streamWriter.WriteLine(line);

					x += xStep;
				}
			}
		}

		#endregion Spline approximation

		#region General

		private static void EnsureFolderExistence(string path)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}

		private int GenerateRandomNumber(int start, int stop)
		{
			int range = stop - start;
			double fraction = range*random.NextDouble();
			int number = (int)(start + fraction);

			return number;
		}

		#endregion General

		#endregion Helpers
	}
}