namespace DataGen.Controls
{
	partial class SplineApproxControl
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
			this.xGroupBox = new System.Windows.Forms.GroupBox();
			this.xStepNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.xStepLabel = new System.Windows.Forms.Label();
			this.xToNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.xToLabel = new System.Windows.Forms.Label();
			this.xFromNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.xFromLabel = new System.Windows.Forms.Label();
			this.yGroupBox = new System.Windows.Forms.GroupBox();
			this.yToNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.yToLabel = new System.Windows.Forms.Label();
			this.yFromNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.yFromLabel = new System.Windows.Forms.Label();
			this.miscGroupBox = new System.Windows.Forms.GroupBox();
			this.variantsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.variantsCountLabel = new System.Windows.Forms.Label();
			this.kNMAxNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.kNMAxLabel = new System.Windows.Forms.Label();
			this.k1MaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.k1MaxLabel = new System.Windows.Forms.Label();
			this.targetFolderBrowseControl = new CoreControls.Controls.BrowseForFolderControl();
			this.targetFolderLabel = new System.Windows.Forms.Label();
			this.loadButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.generateButton = new System.Windows.Forms.Button();
			this.buttonsPanel = new System.Windows.Forms.Panel();
			this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.saveProfileDialog = new System.Windows.Forms.SaveFileDialog();
			this.loadProfileDialog = new System.Windows.Forms.OpenFileDialog();
			this.xGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xStepNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xToNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xFromNumericUpDown)).BeginInit();
			this.yGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.yToNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yFromNumericUpDown)).BeginInit();
			this.miscGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.variantsCountNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kNMAxNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.k1MaxNumericUpDown)).BeginInit();
			this.buttonsPanel.SuspendLayout();
			this.mainTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// xGroupBox
			// 
			this.xGroupBox.Controls.Add(this.xStepNumericUpDown);
			this.xGroupBox.Controls.Add(this.xStepLabel);
			this.xGroupBox.Controls.Add(this.xToNumericUpDown);
			this.xGroupBox.Controls.Add(this.xToLabel);
			this.xGroupBox.Controls.Add(this.xFromNumericUpDown);
			this.xGroupBox.Controls.Add(this.xFromLabel);
			this.xGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xGroupBox.Location = new System.Drawing.Point(3, 3);
			this.xGroupBox.Name = "xGroupBox";
			this.xGroupBox.Size = new System.Drawing.Size(195, 103);
			this.xGroupBox.TabIndex = 0;
			this.xGroupBox.TabStop = false;
			this.xGroupBox.Text = "X";
			// 
			// xStepNumericUpDown
			// 
			this.xStepNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.xStepNumericUpDown.DecimalPlaces = 1;
			this.xStepNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.xStepNumericUpDown.Location = new System.Drawing.Point(42, 66);
			this.xStepNumericUpDown.Name = "xStepNumericUpDown";
			this.xStepNumericUpDown.Size = new System.Drawing.Size(146, 20);
			this.xStepNumericUpDown.TabIndex = 5;
			this.xStepNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// xStepLabel
			// 
			this.xStepLabel.AutoSize = true;
			this.xStepLabel.Location = new System.Drawing.Point(6, 68);
			this.xStepLabel.Name = "xStepLabel";
			this.xStepLabel.Size = new System.Drawing.Size(29, 13);
			this.xStepLabel.TabIndex = 4;
			this.xStepLabel.Text = "Step";
			// 
			// xToNumericUpDown
			// 
			this.xToNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.xToNumericUpDown.Location = new System.Drawing.Point(42, 40);
			this.xToNumericUpDown.Name = "xToNumericUpDown";
			this.xToNumericUpDown.Size = new System.Drawing.Size(146, 20);
			this.xToNumericUpDown.TabIndex = 3;
			this.xToNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// xToLabel
			// 
			this.xToLabel.AutoSize = true;
			this.xToLabel.Location = new System.Drawing.Point(6, 42);
			this.xToLabel.Name = "xToLabel";
			this.xToLabel.Size = new System.Drawing.Size(20, 13);
			this.xToLabel.TabIndex = 2;
			this.xToLabel.Text = "To";
			// 
			// xFromNumericUpDown
			// 
			this.xFromNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.xFromNumericUpDown.Location = new System.Drawing.Point(42, 14);
			this.xFromNumericUpDown.Name = "xFromNumericUpDown";
			this.xFromNumericUpDown.Size = new System.Drawing.Size(146, 20);
			this.xFromNumericUpDown.TabIndex = 1;
			this.xFromNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// xFromLabel
			// 
			this.xFromLabel.AutoSize = true;
			this.xFromLabel.Location = new System.Drawing.Point(6, 16);
			this.xFromLabel.Name = "xFromLabel";
			this.xFromLabel.Size = new System.Drawing.Size(30, 13);
			this.xFromLabel.TabIndex = 0;
			this.xFromLabel.Text = "From";
			// 
			// yGroupBox
			// 
			this.yGroupBox.Controls.Add(this.yToNumericUpDown);
			this.yGroupBox.Controls.Add(this.yToLabel);
			this.yGroupBox.Controls.Add(this.yFromNumericUpDown);
			this.yGroupBox.Controls.Add(this.yFromLabel);
			this.yGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.yGroupBox.Location = new System.Drawing.Point(204, 3);
			this.yGroupBox.Name = "yGroupBox";
			this.yGroupBox.Size = new System.Drawing.Size(196, 103);
			this.yGroupBox.TabIndex = 1;
			this.yGroupBox.TabStop = false;
			this.yGroupBox.Text = "Y";
			// 
			// yToNumericUpDown
			// 
			this.yToNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.yToNumericUpDown.Location = new System.Drawing.Point(42, 40);
			this.yToNumericUpDown.Name = "yToNumericUpDown";
			this.yToNumericUpDown.Size = new System.Drawing.Size(145, 20);
			this.yToNumericUpDown.TabIndex = 7;
			this.yToNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// yToLabel
			// 
			this.yToLabel.AutoSize = true;
			this.yToLabel.Location = new System.Drawing.Point(6, 42);
			this.yToLabel.Name = "yToLabel";
			this.yToLabel.Size = new System.Drawing.Size(20, 13);
			this.yToLabel.TabIndex = 6;
			this.yToLabel.Text = "To";
			// 
			// yFromNumericUpDown
			// 
			this.yFromNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.yFromNumericUpDown.Location = new System.Drawing.Point(42, 14);
			this.yFromNumericUpDown.Name = "yFromNumericUpDown";
			this.yFromNumericUpDown.Size = new System.Drawing.Size(145, 20);
			this.yFromNumericUpDown.TabIndex = 5;
			this.yFromNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// yFromLabel
			// 
			this.yFromLabel.AutoSize = true;
			this.yFromLabel.Location = new System.Drawing.Point(6, 16);
			this.yFromLabel.Name = "yFromLabel";
			this.yFromLabel.Size = new System.Drawing.Size(30, 13);
			this.yFromLabel.TabIndex = 4;
			this.yFromLabel.Text = "From";
			// 
			// miscGroupBox
			// 
			this.miscGroupBox.Controls.Add(this.variantsCountNumericUpDown);
			this.miscGroupBox.Controls.Add(this.variantsCountLabel);
			this.miscGroupBox.Controls.Add(this.kNMAxNumericUpDown);
			this.miscGroupBox.Controls.Add(this.kNMAxLabel);
			this.miscGroupBox.Controls.Add(this.k1MaxNumericUpDown);
			this.miscGroupBox.Controls.Add(this.k1MaxLabel);
			this.miscGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.miscGroupBox.Location = new System.Drawing.Point(406, 3);
			this.miscGroupBox.Name = "miscGroupBox";
			this.miscGroupBox.Size = new System.Drawing.Size(197, 103);
			this.miscGroupBox.TabIndex = 2;
			this.miscGroupBox.TabStop = false;
			this.miscGroupBox.Text = "Misc";
			// 
			// variantsCountNumericUpDown
			// 
			this.variantsCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.variantsCountNumericUpDown.Location = new System.Drawing.Point(71, 68);
			this.variantsCountNumericUpDown.Name = "variantsCountNumericUpDown";
			this.variantsCountNumericUpDown.Size = new System.Drawing.Size(117, 20);
			this.variantsCountNumericUpDown.TabIndex = 9;
			this.variantsCountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// variantsCountLabel
			// 
			this.variantsCountLabel.AutoSize = true;
			this.variantsCountLabel.Location = new System.Drawing.Point(9, 70);
			this.variantsCountLabel.Name = "variantsCountLabel";
			this.variantsCountLabel.Size = new System.Drawing.Size(56, 13);
			this.variantsCountLabel.TabIndex = 8;
			this.variantsCountLabel.Text = "Var. count";
			// 
			// kNMAxNumericUpDown
			// 
			this.kNMAxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.kNMAxNumericUpDown.Location = new System.Drawing.Point(71, 40);
			this.kNMAxNumericUpDown.Name = "kNMAxNumericUpDown";
			this.kNMAxNumericUpDown.Size = new System.Drawing.Size(117, 20);
			this.kNMAxNumericUpDown.TabIndex = 7;
			this.kNMAxNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// kNMAxLabel
			// 
			this.kNMAxLabel.AutoSize = true;
			this.kNMAxLabel.Location = new System.Drawing.Point(6, 42);
			this.kNMAxLabel.Name = "kNMAxLabel";
			this.kNMAxLabel.Size = new System.Drawing.Size(42, 13);
			this.kNMAxLabel.TabIndex = 6;
			this.kNMAxLabel.Text = "Kn max";
			// 
			// k1MaxNumericUpDown
			// 
			this.k1MaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.k1MaxNumericUpDown.Location = new System.Drawing.Point(71, 14);
			this.k1MaxNumericUpDown.Name = "k1MaxNumericUpDown";
			this.k1MaxNumericUpDown.Size = new System.Drawing.Size(117, 20);
			this.k1MaxNumericUpDown.TabIndex = 5;
			this.k1MaxNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// k1MaxLabel
			// 
			this.k1MaxLabel.AutoSize = true;
			this.k1MaxLabel.Location = new System.Drawing.Point(6, 16);
			this.k1MaxLabel.Name = "k1MaxLabel";
			this.k1MaxLabel.Size = new System.Drawing.Size(42, 13);
			this.k1MaxLabel.TabIndex = 4;
			this.k1MaxLabel.Text = "K1 max";
			// 
			// targetFolderBrowseControl
			// 
			this.targetFolderBrowseControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.targetFolderBrowseControl.DialogTitle = "Target folder";
			this.targetFolderBrowseControl.Location = new System.Drawing.Point(76, 1);
			this.targetFolderBrowseControl.Name = "targetFolderBrowseControl";
			this.targetFolderBrowseControl.Size = new System.Drawing.Size(521, 29);
			this.targetFolderBrowseControl.TabIndex = 3;
			// 
			// targetFolderLabel
			// 
			this.targetFolderLabel.AutoSize = true;
			this.targetFolderLabel.Location = new System.Drawing.Point(3, 9);
			this.targetFolderLabel.Name = "targetFolderLabel";
			this.targetFolderLabel.Size = new System.Drawing.Size(67, 13);
			this.targetFolderLabel.TabIndex = 4;
			this.targetFolderLabel.Text = "Target folder";
			// 
			// loadButton
			// 
			this.loadButton.Location = new System.Drawing.Point(6, 36);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(75, 23);
			this.loadButton.TabIndex = 5;
			this.loadButton.Text = "&Load";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(87, 36);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "&Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// generateButton
			// 
			this.generateButton.Location = new System.Drawing.Point(166, 36);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(75, 23);
			this.generateButton.TabIndex = 7;
			this.generateButton.Text = "&Generate";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// buttonsPanel
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.buttonsPanel, 3);
			this.buttonsPanel.Controls.Add(this.targetFolderBrowseControl);
			this.buttonsPanel.Controls.Add(this.targetFolderLabel);
			this.buttonsPanel.Controls.Add(this.generateButton);
			this.buttonsPanel.Controls.Add(this.saveButton);
			this.buttonsPanel.Controls.Add(this.loadButton);
			this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonsPanel.Location = new System.Drawing.Point(3, 112);
			this.buttonsPanel.Name = "buttonsPanel";
			this.buttonsPanel.Size = new System.Drawing.Size(600, 93);
			this.buttonsPanel.TabIndex = 9;
			// 
			// mainTableLayoutPanel
			// 
			this.mainTableLayoutPanel.ColumnCount = 3;
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.mainTableLayoutPanel.Controls.Add(this.xGroupBox, 0, 0);
			this.mainTableLayoutPanel.Controls.Add(this.buttonsPanel, 0, 1);
			this.mainTableLayoutPanel.Controls.Add(this.miscGroupBox, 2, 0);
			this.mainTableLayoutPanel.Controls.Add(this.yGroupBox, 1, 0);
			this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			this.mainTableLayoutPanel.RowCount = 2;
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayoutPanel.Size = new System.Drawing.Size(606, 208);
			this.mainTableLayoutPanel.TabIndex = 10;
			// 
			// saveProfileDialog
			// 
			this.saveProfileDialog.Filter = "XML Files|*.xml";
			this.saveProfileDialog.Title = "Save profile";
			// 
			// loadProfileDialog
			// 
			this.loadProfileDialog.Filter = "XML Files|*.xml";
			this.loadProfileDialog.Title = "Open profile";
			// 
			// SplineApproxControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainTableLayoutPanel);
			this.Name = "SplineApproxControl";
			this.Size = new System.Drawing.Size(606, 208);
			this.xGroupBox.ResumeLayout(false);
			this.xGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.xStepNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xToNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xFromNumericUpDown)).EndInit();
			this.yGroupBox.ResumeLayout(false);
			this.yGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.yToNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yFromNumericUpDown)).EndInit();
			this.miscGroupBox.ResumeLayout(false);
			this.miscGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.variantsCountNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kNMAxNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.k1MaxNumericUpDown)).EndInit();
			this.buttonsPanel.ResumeLayout(false);
			this.buttonsPanel.PerformLayout();
			this.mainTableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox xGroupBox;
		private System.Windows.Forms.NumericUpDown xStepNumericUpDown;
		private System.Windows.Forms.Label xStepLabel;
		private System.Windows.Forms.NumericUpDown xToNumericUpDown;
		private System.Windows.Forms.Label xToLabel;
		private System.Windows.Forms.NumericUpDown xFromNumericUpDown;
		private System.Windows.Forms.Label xFromLabel;
		private System.Windows.Forms.GroupBox yGroupBox;
		private System.Windows.Forms.NumericUpDown yToNumericUpDown;
		private System.Windows.Forms.Label yToLabel;
		private System.Windows.Forms.NumericUpDown yFromNumericUpDown;
		private System.Windows.Forms.Label yFromLabel;
		private System.Windows.Forms.GroupBox miscGroupBox;
		private System.Windows.Forms.NumericUpDown kNMAxNumericUpDown;
		private System.Windows.Forms.Label kNMAxLabel;
		private System.Windows.Forms.NumericUpDown k1MaxNumericUpDown;
		private System.Windows.Forms.Label k1MaxLabel;
		private System.Windows.Forms.NumericUpDown variantsCountNumericUpDown;
		private System.Windows.Forms.Label variantsCountLabel;
		private CoreControls.Controls.BrowseForFolderControl targetFolderBrowseControl;
		private System.Windows.Forms.Label targetFolderLabel;
		private System.Windows.Forms.Button loadButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.Panel buttonsPanel;
		private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
		private System.Windows.Forms.SaveFileDialog saveProfileDialog;
		private System.Windows.Forms.OpenFileDialog loadProfileDialog;
	}
}
