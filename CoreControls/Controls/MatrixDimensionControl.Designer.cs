namespace CoreControls.Controls
{
	partial class MatrixDimensionControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rowCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.rowCountLabel = new System.Windows.Forms.Label();
			this.columnCountLabel = new System.Windows.Forms.Label();
			this.columnCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.rowCountNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.columnCountNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// rowCountNumericUpDown
			// 
			this.rowCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rowCountNumericUpDown.Location = new System.Drawing.Point(84, 3);
			this.rowCountNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.rowCountNumericUpDown.Name = "rowCountNumericUpDown";
			this.rowCountNumericUpDown.Size = new System.Drawing.Size(93, 20);
			this.rowCountNumericUpDown.TabIndex = 0;
			this.rowCountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// rowCountLabel
			// 
			this.rowCountLabel.AutoSize = true;
			this.rowCountLabel.Location = new System.Drawing.Point(3, 5);
			this.rowCountLabel.Name = "rowCountLabel";
			this.rowCountLabel.Size = new System.Drawing.Size(62, 13);
			this.rowCountLabel.TabIndex = 1;
			this.rowCountLabel.Text = "Row count:";
			// 
			// columnCountLabel
			// 
			this.columnCountLabel.AutoSize = true;
			this.columnCountLabel.Location = new System.Drawing.Point(3, 31);
			this.columnCountLabel.Name = "columnCountLabel";
			this.columnCountLabel.Size = new System.Drawing.Size(75, 13);
			this.columnCountLabel.TabIndex = 2;
			this.columnCountLabel.Text = "Column count:";
			// 
			// columnCountNumericUpDown
			// 
			this.columnCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.columnCountNumericUpDown.Location = new System.Drawing.Point(84, 29);
			this.columnCountNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.columnCountNumericUpDown.Name = "columnCountNumericUpDown";
			this.columnCountNumericUpDown.Size = new System.Drawing.Size(93, 20);
			this.columnCountNumericUpDown.TabIndex = 1;
			this.columnCountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MatrixDimensionControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.columnCountNumericUpDown);
			this.Controls.Add(this.columnCountLabel);
			this.Controls.Add(this.rowCountLabel);
			this.Controls.Add(this.rowCountNumericUpDown);
			this.Name = "MatrixDimensionControl";
			this.Size = new System.Drawing.Size(180, 53);
			((System.ComponentModel.ISupportInitialize)(this.rowCountNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.columnCountNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown rowCountNumericUpDown;
		private System.Windows.Forms.Label rowCountLabel;
		private System.Windows.Forms.Label columnCountLabel;
		private System.Windows.Forms.NumericUpDown columnCountNumericUpDown;
	}
}
