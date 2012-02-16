namespace Checker.Controls
{
	partial class MatrixEqualityCheckControl
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
			this.firstMatrixFileLabel = new System.Windows.Forms.Label();
			this.secondMatrixFileLabel = new System.Windows.Forms.Label();
			this.checkButton = new System.Windows.Forms.Button();
			this.browseForFirstMatrixFileControl = new CoreControls.Controls.BrowseForFileControl();
			this.browseForSecondMatrixFileControl = new CoreControls.Controls.BrowseForFileControl();
			this.mainTableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainTableLayout
			// 
			this.mainTableLayout.ColumnCount = 1;
			this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayout.Controls.Add(this.firstMatrixFileLabel, 0, 0);
			this.mainTableLayout.Controls.Add(this.secondMatrixFileLabel, 0, 2);
			this.mainTableLayout.Controls.Add(this.checkButton, 0, 4);
			this.mainTableLayout.Controls.Add(this.browseForFirstMatrixFileControl, 0, 1);
			this.mainTableLayout.Controls.Add(this.browseForSecondMatrixFileControl, 0, 3);
			this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
			this.mainTableLayout.Name = "mainTableLayout";
			this.mainTableLayout.RowCount = 5;
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayout.Size = new System.Drawing.Size(410, 150);
			this.mainTableLayout.TabIndex = 2;
			// 
			// firstMatrixFileLabel
			// 
			this.firstMatrixFileLabel.AutoSize = true;
			this.firstMatrixFileLabel.Location = new System.Drawing.Point(3, 0);
			this.firstMatrixFileLabel.Name = "firstMatrixFileLabel";
			this.firstMatrixFileLabel.Size = new System.Drawing.Size(75, 13);
			this.firstMatrixFileLabel.TabIndex = 0;
			this.firstMatrixFileLabel.Text = "First matrix file:";
			// 
			// secondMatrixFileLabel
			// 
			this.secondMatrixFileLabel.AutoSize = true;
			this.secondMatrixFileLabel.Location = new System.Drawing.Point(3, 47);
			this.secondMatrixFileLabel.Name = "secondMatrixFileLabel";
			this.secondMatrixFileLabel.Size = new System.Drawing.Size(93, 13);
			this.secondMatrixFileLabel.TabIndex = 1;
			this.secondMatrixFileLabel.Text = "Second matrix file:";
			// 
			// checkButton
			// 
			this.checkButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.checkButton.Location = new System.Drawing.Point(167, 97);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(75, 23);
			this.checkButton.TabIndex = 2;
			this.checkButton.Text = "Check";
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// browseForFirstMatrixFileControl
			// 
			this.browseForFirstMatrixFileControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browseForFirstMatrixFileControl.DialogTitle = "Select file with input matrices";
			this.browseForFirstMatrixFileControl.Filter = "Text files|*.txt|All files|*.*";
			this.browseForFirstMatrixFileControl.Location = new System.Drawing.Point(3, 16);
			this.browseForFirstMatrixFileControl.Name = "browseForFirstMatrixFileControl";
			this.browseForFirstMatrixFileControl.Size = new System.Drawing.Size(404, 28);
			this.browseForFirstMatrixFileControl.TabIndex = 3;
			// 
			// browseForSecondMatrixFileControl
			// 
			this.browseForSecondMatrixFileControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browseForSecondMatrixFileControl.DialogTitle = "Select file with calculated matrix";
			this.browseForSecondMatrixFileControl.Filter = "Text files|*.txt|All files|*.*";
			this.browseForSecondMatrixFileControl.Location = new System.Drawing.Point(3, 63);
			this.browseForSecondMatrixFileControl.Name = "browseForSecondMatrixFileControl";
			this.browseForSecondMatrixFileControl.Size = new System.Drawing.Size(404, 28);
			this.browseForSecondMatrixFileControl.TabIndex = 4;
			// 
			// MatrixEqualityCheckControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainTableLayout);
			this.Name = "MatrixEqualityCheckControl";
			this.Size = new System.Drawing.Size(410, 150);
			this.mainTableLayout.ResumeLayout(false);
			this.mainTableLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel mainTableLayout;
		private System.Windows.Forms.Label firstMatrixFileLabel;
		private System.Windows.Forms.Label secondMatrixFileLabel;
		private System.Windows.Forms.Button checkButton;
		private CoreControls.Controls.BrowseForFileControl browseForFirstMatrixFileControl;
		private CoreControls.Controls.BrowseForFileControl browseForSecondMatrixFileControl;
	}
}
