namespace Checker.Controls
{
	partial class PiCalculationCheckControl
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
			this.calculatedPiValueLabel = new System.Windows.Forms.Label();
			this.calculatedPiValueTextBox = new System.Windows.Forms.TextBox();
			this.checkButton = new System.Windows.Forms.Button();
			this.mainTableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainTableLayout
			// 
			this.mainTableLayout.ColumnCount = 1;
			this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayout.Controls.Add(this.calculatedPiValueLabel, 0, 0);
			this.mainTableLayout.Controls.Add(this.calculatedPiValueTextBox, 0, 1);
			this.mainTableLayout.Controls.Add(this.checkButton, 0, 2);
			this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
			this.mainTableLayout.Name = "mainTableLayout";
			this.mainTableLayout.RowCount = 3;
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayout.Size = new System.Drawing.Size(322, 98);
			this.mainTableLayout.TabIndex = 0;
			// 
			// calculatedPiValueLabel
			// 
			this.calculatedPiValueLabel.AutoSize = true;
			this.calculatedPiValueLabel.Location = new System.Drawing.Point(3, 0);
			this.calculatedPiValueLabel.Name = "calculatedPiValueLabel";
			this.calculatedPiValueLabel.Size = new System.Drawing.Size(101, 13);
			this.calculatedPiValueLabel.TabIndex = 0;
			this.calculatedPiValueLabel.Text = "Calculated Pi value:";
			// 
			// calculatedPiValueTextBox
			// 
			this.calculatedPiValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.calculatedPiValueTextBox.Location = new System.Drawing.Point(3, 16);
			this.calculatedPiValueTextBox.Name = "calculatedPiValueTextBox";
			this.calculatedPiValueTextBox.Size = new System.Drawing.Size(316, 20);
			this.calculatedPiValueTextBox.TabIndex = 1;
			// 
			// checkButton
			// 
			this.checkButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.checkButton.Location = new System.Drawing.Point(123, 42);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(75, 23);
			this.checkButton.TabIndex = 2;
			this.checkButton.Text = "Check";
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// PiCalculationCheckControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainTableLayout);
			this.Name = "PiCalculationCheckControl";
			this.Size = new System.Drawing.Size(322, 98);
			this.mainTableLayout.ResumeLayout(false);
			this.mainTableLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel mainTableLayout;
		private System.Windows.Forms.Label calculatedPiValueLabel;
		private System.Windows.Forms.TextBox calculatedPiValueTextBox;
		private System.Windows.Forms.Button checkButton;
	}
}
