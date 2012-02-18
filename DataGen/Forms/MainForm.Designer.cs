namespace DataGen.Forms
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
			this.mainTabs = new System.Windows.Forms.TabControl();
			this.matrixMultiplicationTabPage = new System.Windows.Forms.TabPage();
			this.matrixMultiplicationControl = new DataGen.Controls.MatrixMultiplicationControl();
			this.splineApproxTabPage = new System.Windows.Forms.TabPage();
			this.splineApproxControl = new DataGen.Controls.SplineApproxControl();
			this.mainTabs.SuspendLayout();
			this.matrixMultiplicationTabPage.SuspendLayout();
			this.splineApproxTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainTabs
			// 
			this.mainTabs.Controls.Add(this.matrixMultiplicationTabPage);
			this.mainTabs.Controls.Add(this.splineApproxTabPage);
			this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabs.Location = new System.Drawing.Point(0, 0);
			this.mainTabs.Name = "mainTabs";
			this.mainTabs.SelectedIndex = 0;
			this.mainTabs.Size = new System.Drawing.Size(676, 301);
			this.mainTabs.TabIndex = 0;
			// 
			// matrixMultiplicationTabPage
			// 
			this.matrixMultiplicationTabPage.Controls.Add(this.matrixMultiplicationControl);
			this.matrixMultiplicationTabPage.Location = new System.Drawing.Point(4, 22);
			this.matrixMultiplicationTabPage.Name = "matrixMultiplicationTabPage";
			this.matrixMultiplicationTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.matrixMultiplicationTabPage.Size = new System.Drawing.Size(668, 275);
			this.matrixMultiplicationTabPage.TabIndex = 0;
			this.matrixMultiplicationTabPage.Text = "Matrix multiplication";
			this.matrixMultiplicationTabPage.UseVisualStyleBackColor = true;
			// 
			// matrixMultiplicationControl
			// 
			this.matrixMultiplicationControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.matrixMultiplicationControl.Location = new System.Drawing.Point(3, 3);
			this.matrixMultiplicationControl.Name = "matrixMultiplicationControl";
			this.matrixMultiplicationControl.Size = new System.Drawing.Size(662, 269);
			this.matrixMultiplicationControl.TabIndex = 0;
			// 
			// splineApproxTabPage
			// 
			this.splineApproxTabPage.Controls.Add(this.splineApproxControl);
			this.splineApproxTabPage.Location = new System.Drawing.Point(4, 22);
			this.splineApproxTabPage.Name = "splineApproxTabPage";
			this.splineApproxTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.splineApproxTabPage.Size = new System.Drawing.Size(668, 275);
			this.splineApproxTabPage.TabIndex = 1;
			this.splineApproxTabPage.Text = "Spline approximation";
			this.splineApproxTabPage.UseVisualStyleBackColor = true;
			// 
			// splineApproxControl
			// 
			this.splineApproxControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splineApproxControl.Location = new System.Drawing.Point(3, 3);
			this.splineApproxControl.Name = "splineApproxControl";
			this.splineApproxControl.Size = new System.Drawing.Size(662, 269);
			this.splineApproxControl.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 301);
			this.Controls.Add(this.mainTabs);
			this.Name = "MainForm";
			this.Text = "DataGen";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.mainTabs.ResumeLayout(false);
			this.matrixMultiplicationTabPage.ResumeLayout(false);
			this.splineApproxTabPage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl mainTabs;
		private System.Windows.Forms.TabPage matrixMultiplicationTabPage;
		private Controls.MatrixMultiplicationControl matrixMultiplicationControl;
		private System.Windows.Forms.TabPage splineApproxTabPage;
		private Controls.SplineApproxControl splineApproxControl;
	}
}