using System.Collections.Generic;
using System.IO;

namespace MathClasses.Classes
{
	public class Matrix
	{
		#region Fields

		private readonly List<Vector> rows = new List<Vector>();
		private readonly object setElementLock = new object();

		#endregion Fields

		#region Properties

		public bool IsValid
		{
			get
			{
				int elementsCount = -1;
				foreach (Vector row in rows)
				{
					if (elementsCount == -1)
					{
						elementsCount = row.ElementsCount;
					}
					else if (elementsCount != row.ElementsCount)
					{
						return false;
					}
				}

				return true;
			}
		}

		public int this[int rowIndex, int columnIndex]
		{
			get
			{
				Vector row = rows[rowIndex];
				int element = row[columnIndex];

				return element;
			}
			set
			{
				lock (setElementLock)
				{
					Vector row = rows[rowIndex];
					row[columnIndex] = value;
				}
			}
		}

		public int RowCount
		{
			get { return rows.Count; }
		}

		public int ColumnCount
		{
			get
			{
				return rows.Count == 0
				       	? 0
				       	: rows[0].ElementsCount;
			}
		}

		#endregion Properties

		#region Constructors

		public Matrix()
		{
			//
		}

		public Matrix(int rowCount, int columnCount)
		{
			for (int i = 0; i < rowCount; i++)
			{
				Vector row = new Vector(columnCount);
				rows.Add(row);
			}
		}

		#endregion Constructors

		#region Methods

		public void LoadLine(string line)
		{
			Vector row = new Vector(line);
			rows.Add(row);
		}

		public void Print(TextWriter textWriter)
		{
			foreach (Vector row in rows)
			{
				textWriter.WriteLine(row.ToString());
			}
		}

		public bool IsEqualTo(Matrix matrix)
		{
			if (RowCount != matrix.RowCount || ColumnCount != matrix.ColumnCount)
			{
				return false;
			}

			for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
			{
				for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
				{
					int element = this[rowIndex, columnIndex];
					int matrixElement = matrix[rowIndex, columnIndex];
					if (element != matrixElement)
					{
						return false;
					}
				}
			}

			return true;
		}

		#endregion Methods
	}
}