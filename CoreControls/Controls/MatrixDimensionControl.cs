using System.ComponentModel;
using System.Windows.Forms;
using CoreControls.Data;

namespace CoreControls.Controls
{
	public partial class MatrixDimensionControl : UserControl
	{
		#region Properties

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public MatrixDimension MatrixDimension
		{
			get
			{
				int rowCount = (int)rowCountNumericUpDown.Value;
				int columnCount = (int)columnCountNumericUpDown.Value;
				MatrixDimension dimension = new MatrixDimension(rowCount, columnCount);

				return dimension;
			}
			set
			{
				rowCountNumericUpDown.Value = value.RowCount;
				columnCountNumericUpDown.Value = value.ColumnCount;
			}
		}

		#endregion Properties

		#region Constructors

		public MatrixDimensionControl()
		{
			InitializeComponent();
		}

		#endregion Constructors
	}
}
