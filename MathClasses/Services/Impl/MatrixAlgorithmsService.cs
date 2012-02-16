using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using MathClasses.Classes;
using MathClasses.Helpers;
using MathClasses.Properties;

namespace MathClasses.Services.Impl
{
	public class MatrixAlgorithmsService : IMatrixAlgorithmsService
	{
		#region IMatrixAlgorithmsService implementation

		public Matrix LoadMatrix(string filePath)
		{
			Matrix matrix = new Matrix();
			using (StreamReader streamReader = File.OpenText(filePath))
			{
				string line;
				while ((line = streamReader.ReadLine()) != null)
				{
					matrix.LoadLine(line);
				}
			}

			return matrix;
		}

		public void LoadMatrices(string filePath, Matrix firstMatrix, Matrix secondMatrix)
		{
			Matrix activeMatrix = firstMatrix;

			using (StreamReader streamReader = File.OpenText(filePath))
			{
				string line;
				while ((line = streamReader.ReadLine()) != null)
				{
					if (string.IsNullOrEmpty(line))
					{
						activeMatrix = secondMatrix;
					}
					else
					{
						activeMatrix.LoadLine(line);
					}
				}
			}
		}

		public Matrix SimpleMultiplication(Matrix firstMatrix, Matrix secondMatrix)
		{
			CheckMultiplicationPossibility(firstMatrix, secondMatrix);

			int rowCount = firstMatrix.RowCount;
			int columnCount = secondMatrix.ColumnCount;
			Matrix matrix = new Matrix(rowCount, columnCount);
			for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
			{
				for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
				{
					int element = 0;
					for (int index = 0; index < firstMatrix.ColumnCount; index++)
					{
						element += (firstMatrix[rowIndex, index]*secondMatrix[index, columnIndex]);
					}
					matrix[rowIndex, columnIndex] = element;
				}
			}

			return matrix;
		}

		public Matrix ParallelMultiplication(Matrix firstMatrix, Matrix secondMatrix)
		{
			const int submatrixCount = 2;
			int firstBorder = firstMatrix.RowCount/submatrixCount;
			int secondBorder = secondMatrix.ColumnCount/submatrixCount;

			SubmatrixDimension[] firstSubmatrixDimensions =
				{
					new SubmatrixDimension(0, 0, firstBorder, firstMatrix.ColumnCount),
					new SubmatrixDimension(firstBorder, 0, firstMatrix.RowCount - firstBorder, firstMatrix.ColumnCount)
				};
			SubmatrixDimension[] secondSubmatrixDimensions =
				{
					new SubmatrixDimension(0, 0, secondMatrix.RowCount, secondBorder),
					new SubmatrixDimension(0, secondBorder, secondMatrix.RowCount, secondMatrix.ColumnCount - secondBorder)
				};
			Matrix matrix = new Matrix(firstMatrix.RowCount, secondMatrix.ColumnCount);

			List<ManualResetEvent> resetEvents = new List<ManualResetEvent>();

			foreach (SubmatrixDimension firstSubmatrixDimension in firstSubmatrixDimensions)
			{
				foreach (SubmatrixDimension secondSubmatrixDimension in secondSubmatrixDimensions)
				{
					ManualResetEvent resetEvent = new ManualResetEvent(false);
					resetEvents.Add(resetEvent);

					SubmatrixDimension firstDimension = firstSubmatrixDimension;
					SubmatrixDimension secondDimension = secondSubmatrixDimension;
					ThreadPool.QueueUserWorkItem(
						delegate
						{
							ParallerWorker(firstMatrix, secondMatrix, firstDimension, secondDimension, matrix, resetEvent);
						});
				}
			}

			WaitHandle.WaitAll(resetEvents.ToArray());

			return matrix;
		}

		#endregion IMatrixAlgorithmsService implementation

		#region Helpers

		private static void CheckMultiplicationPossibility(Matrix firstMatrix, Matrix secondMatrix)
		{
			bool canMultiply = (firstMatrix.ColumnCount == secondMatrix.RowCount);
			if (!canMultiply)
			{
				throw new InvalidOperationException(Resources.Exceptions_CannotMultiplyDueToDimensionsMismatch);
			}
		}

		private static void ParallerWorker(
			Matrix firstMatrix, Matrix secondMatrix, SubmatrixDimension firstSubmatrixDimension,
			SubmatrixDimension secondSubmatrixDimension,
			Matrix matrix, EventWaitHandle resetEvent)
		{
			for (int rowIndex = firstSubmatrixDimension.Row;
			     rowIndex < firstSubmatrixDimension.Row + firstSubmatrixDimension.RowCount;
			     rowIndex++)
			{
				for (int columnIndex = secondSubmatrixDimension.Column;
				     columnIndex < secondSubmatrixDimension.Column + secondSubmatrixDimension.ColumnCount;
				     columnIndex++)
				{
					int element = 0;
					for (int index = firstSubmatrixDimension.Column;
					     index < firstSubmatrixDimension.Column + firstSubmatrixDimension.ColumnCount;
					     index++)
					{
						element += (firstMatrix[rowIndex, index]*secondMatrix[index, columnIndex]);
					}
					matrix[rowIndex, columnIndex] = element;
				}
			}

			resetEvent.Set();
		}

		#endregion Helpers
	}
}