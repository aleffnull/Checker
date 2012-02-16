namespace CoreControls.Data
{
	public class MatrixDimension
	{
		#region Properties

		public int RowCount { get; set; }
		public int ColumnCount { get; set; }

		public bool IsValid
		{
			get { return RowCount > 0 && ColumnCount > 0; }
		}

		#endregion Properties

		#region Constructors

		public MatrixDimension()
		{
			//
		}

		public MatrixDimension(int rowCount, int columnCount)
		{
			RowCount = rowCount;
			ColumnCount = columnCount;
		}

		#endregion Constructors
	}
}