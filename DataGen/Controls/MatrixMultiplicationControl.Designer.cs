namespace DataGen.Controls
{
	partial class MatrixMultiplicationControl
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
			this.matricesTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.firstMatrixLabel = new System.Windows.Forms.Label();
			this.secondMatrixLabel = new System.Windows.Forms.Label();
			this.firstMatrixDimensionControl = new CoreControls.Controls.MatrixDimensionControl();
			this.secondMatrixDimensionControl = new CoreControls.Controls.MatrixDimensionControl();
			this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.outputFolderLabel = new System.Windows.Forms.Label();
			this.numberOfFilesNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.numberOfFilesLabel = new System.Windows.Forms.Label();
			this.maxElementValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.maxElementValueLabel = new System.Windows.Forms.Label();
			this.browseForFolderControl = new CoreControls.Controls.BrowseForFolderControl();
			this.buttonsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.loadProfileButton = new System.Windows.Forms.Button();
			this.saveProfileButton = new System.Windows.Forms.Button();
			this.generateButton = new System.Windows.Forms.Button();
			this.loadProfileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveProfileDialog = new System.Windows.Forms.SaveFileDialog();
			this.matricesTableLayout.SuspendLayout();
			this.mainTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberOfFilesNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxElementValueNumericUpDown)).BeginInit();
			this.buttonsFlowLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// matricesTableLayout
			// 
			this.matricesTableLayout.ColumnCount = 2;
			this.mainTableLayout.SetColumnSpan(this.matricesTableLayout, 2);
			this.matricesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.matricesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.matricesTableLayout.Controls.Add(this.firstMatrixLabel, 0, 0);
			this.matricesTableLayout.Controls.Add(this.secondMatrixLabel, 1, 0);
			this.matricesTableLayout.Controls.Add(this.firstMatrixDimensionControl, 0, 1);
			this.matricesTableLayout.Controls.Add(this.secondMatrixDimensionControl, 1, 1);
			this.matricesTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.matricesTableLayout.Location = new System.Drawing.Point(3, 3);
			this.matricesTableLayout.Name = "matricesTableLayout";
			this.matricesTableLayout.RowCount = 2;
			this.matricesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.matricesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.matricesTableLayout.Size = new System.Drawing.Size(608, 74);
			this.matricesTableLayout.TabIndex = 3;
			// 
			// firstMatrixLabel
			// 
			this.firstMatrixLabel.AutoSize = true;
			this.firstMatrixLabel.Location = new System.Drawing.Point(3, 0);
			this.firstMatrixLabel.Name = "firstMatrixLabel";
			this.firstMatrixLabel.Size = new System.Drawing.Size(56, 13);
			this.firstMatrixLabel.TabIndex = 0;
			this.firstMatrixLabel.Text = "First matrix";
			// 
			// secondMatrixLabel
			// 
			this.secondMatrixLabel.AutoSize = true;
			this.secondMatrixLabel.Location = new System.Drawing.Point(307, 0);
			this.secondMatrixLabel.Name = "secondMatrixLabel";
			this.secondMatrixLabel.Size = new System.Drawing.Size(74, 13);
			this.secondMatrixLabel.TabIndex = 1;
			this.secondMatrixLabel.Text = "Second matrix";
			// 
			// firstMatrixDimensionControl
			// 
			this.firstMatrixDimensionControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.firstMatrixDimensionControl.Location = new System.Drawing.Point(3, 16);
			this.firstMatrixDimensionControl.Name = "firstMatrixDimensionControl";
			this.firstMatrixDimensionControl.Size = new System.Drawing.Size(298, 55);
			this.firstMatrixDimensionControl.TabIndex = 0;
			// 
			// secondMatrixDimensionControl
			// 
			this.secondMatrixDimensionControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.secondMatrixDimensionControl.Location = new System.Drawing.Point(307, 16);
			this.secondMatrixDimensionControl.Name = "secondMatrixDimensionControl";
			this.secondMatrixDimensionControl.Size = new System.Drawing.Size(298, 55);
			this.secondMatrixDimensionControl.TabIndex = 1;
			// 
			// mainTableLayout
			// 
			this.mainTableLayout.ColumnCount = 2;
			this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayout.Controls.Add(this.outputFolderLabel, 0, 3);
			this.mainTableLayout.Controls.Add(this.numberOfFilesNumericUpDown, 1, 2);
			this.mainTableLayout.Controls.Add(this.numberOfFilesLabel, 0, 2);
			this.mainTableLayout.Controls.Add(this.maxElementValueNumericUpDown, 1, 1);
			this.mainTableLayout.Controls.Add(this.maxElementValueLabel, 0, 1);
			this.mainTableLayout.Controls.Add(this.matricesTableLayout, 0, 0);
			this.mainTableLayout.Controls.Add(this.browseForFolderControl, 1, 3);
			this.mainTableLayout.Controls.Add(this.buttonsFlowLayout, 1, 4);
			this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
			this.mainTableLayout.Name = "mainTableLayout";
			this.mainTableLayout.RowCount = 5;
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayout.Size = new System.Drawing.Size(614, 231);
			this.mainTableLayout.TabIndex = 4;
			// 
			// outputFolderLabel
			// 
			this.outputFolderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.outputFolderLabel.AutoSize = true;
			this.outputFolderLabel.Location = new System.Drawing.Point(3, 143);
			this.outputFolderLabel.Name = "outputFolderLabel";
			this.outputFolderLabel.Size = new System.Drawing.Size(71, 13);
			this.outputFolderLabel.TabIndex = 12;
			this.outputFolderLabel.Text = "Output folder:";
			// 
			// numberOfFilesNumericUpDown
			// 
			this.numberOfFilesNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numberOfFilesNumericUpDown.Location = new System.Drawing.Point(108, 109);
			this.numberOfFilesNumericUpDown.Name = "numberOfFilesNumericUpDown";
			this.numberOfFilesNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.numberOfFilesNumericUpDown.Size = new System.Drawing.Size(503, 20);
			this.numberOfFilesNumericUpDown.TabIndex = 11;
			this.numberOfFilesNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// numberOfFilesLabel
			// 
			this.numberOfFilesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numberOfFilesLabel.AutoSize = true;
			this.numberOfFilesLabel.Location = new System.Drawing.Point(3, 112);
			this.numberOfFilesLabel.Name = "numberOfFilesLabel";
			this.numberOfFilesLabel.Size = new System.Drawing.Size(80, 13);
			this.numberOfFilesLabel.TabIndex = 10;
			this.numberOfFilesLabel.Text = "Number of files:";
			// 
			// maxElementValueNumericUpDown
			// 
			this.maxElementValueNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxElementValueNumericUpDown.Location = new System.Drawing.Point(108, 83);
			this.maxElementValueNumericUpDown.Name = "maxElementValueNumericUpDown";
			this.maxElementValueNumericUpDown.Size = new System.Drawing.Size(503, 20);
			this.maxElementValueNumericUpDown.TabIndex = 9;
			this.maxElementValueNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// maxElementValueLabel
			// 
			this.maxElementValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.maxElementValueLabel.AutoSize = true;
			this.maxElementValueLabel.Location = new System.Drawing.Point(3, 86);
			this.maxElementValueLabel.Name = "maxElementValueLabel";
			this.maxElementValueLabel.Size = new System.Drawing.Size(99, 13);
			this.maxElementValueLabel.TabIndex = 8;
			this.maxElementValueLabel.Text = "Max element value:";
			// 
			// browseForFolderControl
			// 
			this.browseForFolderControl.DialogTitle = "";
			this.browseForFolderControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browseForFolderControl.Location = new System.Drawing.Point(108, 135);
			this.browseForFolderControl.Name = "browseForFolderControl";
			this.browseForFolderControl.Size = new System.Drawing.Size(503, 29);
			this.browseForFolderControl.TabIndex = 13;
			// 
			// buttonsFlowLayout
			// 
			this.buttonsFlowLayout.Controls.Add(this.loadProfileButton);
			this.buttonsFlowLayout.Controls.Add(this.saveProfileButton);
			this.buttonsFlowLayout.Controls.Add(this.generateButton);
			this.buttonsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonsFlowLayout.Location = new System.Drawing.Point(108, 170);
			this.buttonsFlowLayout.Name = "buttonsFlowLayout";
			this.buttonsFlowLayout.Size = new System.Drawing.Size(503, 58);
			this.buttonsFlowLayout.TabIndex = 14;
			// 
			// loadProfileButton
			// 
			this.loadProfileButton.Location = new System.Drawing.Point(3, 3);
			this.loadProfileButton.Name = "loadProfileButton";
			this.loadProfileButton.Size = new System.Drawing.Size(75, 23);
			this.loadProfileButton.TabIndex = 0;
			this.loadProfileButton.Text = "Load profile";
			this.loadProfileButton.UseVisualStyleBackColor = true;
			this.loadProfileButton.Click += new System.EventHandler(this.loadProfileButton_Click);
			// 
			// saveProfileButton
			// 
			this.saveProfileButton.Location = new System.Drawing.Point(84, 3);
			this.saveProfileButton.Name = "saveProfileButton";
			this.saveProfileButton.Size = new System.Drawing.Size(75, 23);
			this.saveProfileButton.TabIndex = 1;
			this.saveProfileButton.Text = "Save profile";
			this.saveProfileButton.UseVisualStyleBackColor = true;
			this.saveProfileButton.Click += new System.EventHandler(this.saveProfileButton_Click);
			// 
			// generateButton
			// 
			this.generateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.generateButton.Location = new System.Drawing.Point(165, 3);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(75, 23);
			this.generateButton.TabIndex = 2;
			this.generateButton.Text = "Generate";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// loadProfileDialog
			// 
			this.loadProfileDialog.Filter = "XML Files|*.xml";
			this.loadProfileDialog.Title = "Load profile";
			// 
			// saveProfileDialog
			// 
			this.saveProfileDialog.Filter = "XML Files|*.xml";
			this.saveProfileDialog.Title = "Save profile";
			// 
			// MatrixMultiplicationControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainTableLayout);
			this.Name = "MatrixMultiplicationControl";
			this.Size = new System.Drawing.Size(614, 231);
			this.matricesTableLayout.ResumeLayout(false);
			this.matricesTableLayout.PerformLayout();
			this.mainTableLayout.ResumeLayout(false);
			this.mainTableLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberOfFilesNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxElementValueNumericUpDown)).EndInit();
			this.buttonsFlowLayout.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel matricesTableLayout;
		private System.Windows.Forms.Label firstMatrixLabel;
		private System.Windows.Forms.Label secondMatrixLabel;
		private CoreControls.Controls.MatrixDimensionControl firstMatrixDimensionControl;
		private CoreControls.Controls.MatrixDimensionControl secondMatrixDimensionControl;
		private System.Windows.Forms.TableLayoutPanel mainTableLayout;
		private System.Windows.Forms.Label maxElementValueLabel;
		private System.Windows.Forms.NumericUpDown maxElementValueNumericUpDown;
		private System.Windows.Forms.Label numberOfFilesLabel;
		private System.Windows.Forms.NumericUpDown numberOfFilesNumericUpDown;
		private System.Windows.Forms.Label outputFolderLabel;
		private CoreControls.Controls.BrowseForFolderControl browseForFolderControl;
		private System.Windows.Forms.FlowLayoutPanel buttonsFlowLayout;
		private System.Windows.Forms.Button loadProfileButton;
		private System.Windows.Forms.Button saveProfileButton;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.OpenFileDialog loadProfileDialog;
		private System.Windows.Forms.SaveFileDialog saveProfileDialog;
	}
}
