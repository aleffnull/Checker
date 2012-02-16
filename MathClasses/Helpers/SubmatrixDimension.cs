namespace MathClasses.Helpers
{
	internal class SubmatrixDimension
	{
		#region Properties

		public int Row { get; private set; }
		public int Column { get; private set; }
		public int RowCount { get; private set; }
		public int ColumnCount { get; private set; }

		#endregion Properties

		#region Constructors

		public SubmatrixDimension(int row, int column, int rowCount, int columnCount)
		{
			Row = row;
			Column = column;
			RowCount = rowCount;
			ColumnCount = columnCount;
		}

		#endregion Constructors
	}
}