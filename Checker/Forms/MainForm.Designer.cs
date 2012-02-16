namespace Checker.Forms
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
			this.checkTypesTabControl = new System.Windows.Forms.TabControl();
			this.matrixMultiplicationTabPage = new System.Windows.Forms.TabPage();
			this.matrixMultiplicationCheckControl = new Checker.Controls.MatrixMultiplicationCheckControl();
			this.matrixEqualityTabPage = new System.Windows.Forms.TabPage();
			this.matrixEqualityCheckControl = new Checker.Controls.MatrixEqualityCheckControl();
			this.logRichTextBox = new System.Windows.Forms.RichTextBox();
			this.piCalculationTabPage = new System.Windows.Forms.TabPage();
			this.piCalculationCheckControl = new Checker.Controls.PiCalculationCheckControl();
			this.mainSplitContainer.Panel1.SuspendLayout();
			this.mainSplitContainer.Panel2.SuspendLayout();
			this.mainSplitContainer.SuspendLayout();
			this.checkTypesTabControl.SuspendLayout();
			this.matrixMultiplicationTabPage.SuspendLayout();
			this.matrixEqualityTabPage.SuspendLayout();
			this.piCalculationTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainSplitContainer
			// 
			this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.mainSplitContainer.Name = "mainSplitContainer";
			this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// mainSplitContainer.Panel1
			// 
			this.mainSplitContainer.Panel1.Controls.Add(this.checkTypesTabControl);
			// 
			// mainSplitContainer.Panel2
			// 
			this.mainSplitContainer.Panel2.Controls.Add(this.logRichTextBox);
			this.mainSplitContainer.Size = new System.Drawing.Size(516, 259);
			this.mainSplitContainer.SplitterDistance = 162;
			this.mainSplitContainer.TabIndex = 0;
			// 
			// checkTypesTabControl
			// 
			this.checkTypesTabControl.Controls.Add(this.matrixMultiplicationTabPage);
			this.checkTypesTabControl.Controls.Add(this.matrixEqualityTabPage);
			this.checkTypesTabControl.Controls.Add(this.piCalculationTabPage);
			this.checkTypesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkTypesTabControl.Location = new System.Drawing.Point(0, 0);
			this.checkTypesTabControl.Name = "checkTypesTabControl";
			this.checkTypesTabControl.SelectedIndex = 0;
			this.checkTypesTabControl.Size = new System.Drawing.Size(516, 162);
			this.checkTypesTabControl.TabIndex = 0;
			// 
			// matrixMultiplicationTabPage
			// 
			this.matrixMultiplicationTabPage.Controls.Add(this.matrixMultiplicationCheckControl);
			this.matrixMultiplicationTabPage.Location = new System.Drawing.Point(4, 22);
			this.matrixMultiplicationTabPage.Name = "matrixMultiplicationTabPage";
			this.matrixMultiplicationTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.matrixMultiplicationTabPage.Size = new System.Drawing.Size(508, 136);
			this.matrixMultiplicationTabPage.TabIndex = 0;
			this.matrixMultiplicationTabPage.Text = "Matrix multiplication";
			this.matrixMultiplicationTabPage.UseVisualStyleBackColor = true;
			// 
			// matrixMultiplicationCheckControl
			// 
			this.matrixMultiplicationCheckControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.matrixMultiplicationCheckControl.Location = new System.Drawing.Point(3, 3);
			this.matrixMultiplicationCheckControl.Name = "matrixMultiplicationCheckControl";
			this.matrixMultiplicationCheckControl.Size = new System.Drawing.Size(502, 130);
			this.matrixMultiplicationCheckControl.TabIndex = 0;
			// 
			// matrixEqualityTabPage
			// 
			this.matrixEqualityTabPage.Controls.Add(this.matrixEqualityCheckControl);
			this.matrixEqualityTabPage.Location = new System.Drawing.Point(4, 22);
			this.matrixEqualityTabPage.Name = "matrixEqualityTabPage";
			this.matrixEqualityTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.matrixEqualityTabPage.Size = new System.Drawing.Size(508, 136);
			this.matrixEqualityTabPage.TabIndex = 1;
			this.matrixEqualityTabPage.Text = "Matrix equality";
			this.matrixEqualityTabPage.UseVisualStyleBackColor = true;
			// 
			// matrixEqualityCheckControl
			// 
			this.matrixEqualityCheckControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.matrixEqualityCheckControl.Location = new System.Drawing.Point(3, 3);
			this.matrixEqualityCheckControl.Name = "matrixEqualityCheckControl";
			this.matrixEqualityCheckControl.Size = new System.Drawing.Size(502, 130);
			this.matrixEqualityCheckControl.TabIndex = 0;
			// 
			// logRichTextBox
			// 
			this.logRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logRichTextBox.Location = new System.Drawing.Point(0, 0);
			this.logRichTextBox.Name = "logRichTextBox";
			this.logRichTextBox.ReadOnly = true;
			this.logRichTextBox.Size = new System.Drawing.Size(516, 93);
			this.logRichTextBox.TabIndex = 0;
			this.logRichTextBox.Text = "";
			// 
			// piCalculationTabPage
			// 
			this.piCalculationTabPage.Controls.Add(this.piCalculationCheckControl);
			this.piCalculationTabPage.Location = new System.Drawing.Point(4, 22);
			this.piCalculationTabPage.Name = "piCalculationTabPage";
			this.piCalculationTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.piCalculationTabPage.Size = new System.Drawing.Size(508, 136);
			this.piCalculationTabPage.TabIndex = 2;
			this.piCalculationTabPage.Text = "Pi calculation";
			this.piCalculationTabPage.UseVisualStyleBackColor = true;
			// 
			// piCalculationCheckControl
			// 
			this.piCalculationCheckControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.piCalculationCheckControl.Location = new System.Drawing.Point(3, 3);
			this.piCalculationCheckControl.Name = "piCalculationCheckControl";
			this.piCalculationCheckControl.Size = new System.Drawing.Size(502, 130);
			this.piCalculationCheckControl.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 259);
			this.Controls.Add(this.mainSplitContainer);
			this.Name = "MainForm";
			this.Text = "Checker";
			this.mainSplitContainer.Panel1.ResumeLayout(false);
			this.mainSplitContainer.Panel2.ResumeLayout(false);
			this.mainSplitContainer.ResumeLayout(false);
			this.checkTypesTabControl.ResumeLayout(false);
			this.matrixMultiplicationTabPage.ResumeLayout(false);
			this.matrixEqualityTabPage.ResumeLayout(false);
			this.piCalculationTabPage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer mainSplitContainer;
		private System.Windows.Forms.RichTextBox logRichTextBox;
		private System.Windows.Forms.TabControl checkTypesTabControl;
		private System.Windows.Forms.TabPage matrixMultiplicationTabPage;
		private Controls.MatrixMultiplicationCheckControl matrixMultiplicationCheckControl;
		private System.Windows.Forms.TabPage matrixEqualityTabPage;
		private Controls.MatrixEqualityCheckControl matrixEqualityCheckControl;
		private System.Windows.Forms.TabPage piCalculationTabPage;
		private Controls.PiCalculationCheckControl piCalculationCheckControl;
	}
}


