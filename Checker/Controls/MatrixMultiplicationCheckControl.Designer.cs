namespace Checker.Controls
{
	partial class MatrixMultiplicationCheckControl
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
			this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.inputFileLabel = new System.Windows.Forms.Label();
			this.outputFileLabel = new System.Windows.Forms.Label();
			this.checkButton = new System.Windows.Forms.Button();
			this.browseForInputFileControl = new CoreControls.Controls.BrowseForFileControl();
			this.browseForOutputFileControl = new CoreControls.Controls.BrowseForFileControl();
			this.mainTableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainTableLayout
			// 
			this.mainTableLayout.ColumnCount = 1;
			this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayout.Controls.Add(this.inputFileLabel, 0, 0);
			this.mainTableLayout.Controls.Add(this.outputFileLabel, 0, 2);
			this.mainTableLayout.Controls.Add(this.checkButton, 0, 4);
			this.mainTableLayout.Controls.Add(this.browseForInputFileControl, 0, 1);
			this.mainTableLayout.Controls.Add(this.browseForOutputFileControl, 0, 3);
			this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
			this.mainTableLayout.Name = "mainTableLayout";
			this.mainTableLayout.RowCount = 5;
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayout.Size = new System.Drawing.Size(417, 143);
			this.mainTableLayout.TabIndex = 1;
			// 
			// inputFileLabel
			// 
			this.inputFileLabel.AutoSize = true;
			this.inputFileLabel.Location = new System.Drawing.Point(3, 0);
			this.inputFileLabel.Name = "inputFileLabel";
			this.inputFileLabel.Size = new System.Drawing.Size(50, 13);
			this.inputFileLabel.TabIndex = 0;
			this.inputFileLabel.Text = "Input file:";
			// 
			// outputFileLabel
			// 
			this.outputFileLabel.AutoSize = true;
			this.outputFileLabel.Location = new System.Drawing.Point(3, 47);
			this.outputFileLabel.Name = "outputFileLabel";
			this.outputFileLabel.Size = new System.Drawing.Size(58, 13);
			this.outputFileLabel.TabIndex = 1;
			this.outputFileLabel.Text = "Output file:";
			// 
			// checkButton
			// 
			this.checkButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.checkButton.Location = new System.Drawing.Point(171, 97);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(75, 23);
			this.checkButton.TabIndex = 2;
			this.checkButton.Text = "Check";
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// browseForInputFileControl
			// 
			this.browseForInputFileControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browseForInputFileControl.DialogTitle = "Select file with input matrices";
			this.browseForInputFileControl.Filter = "Text files|*.txt|All files|*.*";
			this.browseForInputFileControl.Location = new System.Drawing.Point(3, 16);
			this.browseForInputFileControl.Name = "browseForInputFileControl";
			this.browseForInputFileControl.Size = new System.Drawing.Size(411, 28);
			this.browseForInputFileControl.TabIndex = 3;
			// 
			// browseForOutputFileControl
			// 
			this.browseForOutputFileControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browseForOutputFileControl.DialogTitle = "Select file with calculated matrix";
			this.browseForOutputFileControl.Filter = "Text files|*.txt|All files|*.*";
			this.browseForOutputFileControl.Location = new System.Drawing.Point(3, 63);
			this.browseForOutputFileControl.Name = "browseForOutputFileControl";
			this.browseForOutputFileControl.Size = new System.Drawing.Size(411, 28);
			this.browseForOutputFileControl.TabIndex = 4;
			// 
			// MatrixMultiplicationCheckControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainTableLayout);
			this.Name = "MatrixMultiplicationCheckControl";
			this.Size = new System.Drawing.Size(417, 143);
			this.mainTableLayout.ResumeLayout(false);
			this.mainTableLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel mainTableLayout;
		private System.Windows.Forms.Label inputFileLabel;
		private System.Windows.Forms.Label outputFileLabel;
		private System.Windows.Forms.Button checkButton;
		private CoreControls.Controls.BrowseForFileControl browseForInputFileControl;
		private CoreControls.Controls.BrowseForFileControl browseForOutputFileControl;

	}
}
