namespace Accio.UI
{
	partial class FormWait
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
			this.PanelBorder = new System.Windows.Forms.Panel();
			this.ProgressPanelSettingUpDownload = new DevExpress.XtraWaitForm.ProgressPanel();
			this.PanelBorder.SuspendLayout();
			this.SuspendLayout();
			// 
			// PanelBorder
			// 
			this.PanelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
			this.PanelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelBorder.Controls.Add(this.ProgressPanelSettingUpDownload);
			this.PanelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelBorder.Location = new System.Drawing.Point(0, 0);
			this.PanelBorder.Name = "PanelBorder";
			this.PanelBorder.Size = new System.Drawing.Size(276, 95);
			this.PanelBorder.TabIndex = 1;
			// 
			// ProgressPanelSettingUpDownload
			// 
			this.ProgressPanelSettingUpDownload.AnimationElementCount = 10;
			this.ProgressPanelSettingUpDownload.AnimationToTextDistance = 10;
			this.ProgressPanelSettingUpDownload.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.ProgressPanelSettingUpDownload.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
			this.ProgressPanelSettingUpDownload.Appearance.Options.UseBackColor = true;
			this.ProgressPanelSettingUpDownload.Appearance.Options.UseForeColor = true;
			this.ProgressPanelSettingUpDownload.Appearance.Options.UseTextOptions = true;
			this.ProgressPanelSettingUpDownload.AppearanceCaption.ForeColor = System.Drawing.SystemColors.Control;
			this.ProgressPanelSettingUpDownload.AppearanceCaption.Options.UseForeColor = true;
			this.ProgressPanelSettingUpDownload.AppearanceDescription.ForeColor = System.Drawing.SystemColors.Control;
			this.ProgressPanelSettingUpDownload.AppearanceDescription.Options.UseForeColor = true;
			this.ProgressPanelSettingUpDownload.Location = new System.Drawing.Point(28, 14);
			this.ProgressPanelSettingUpDownload.Name = "ProgressPanelSettingUpDownload";
			this.ProgressPanelSettingUpDownload.Size = new System.Drawing.Size(220, 67);
			this.ProgressPanelSettingUpDownload.TabIndex = 0;
			this.ProgressPanelSettingUpDownload.Text = "progressPanel1";
			this.ProgressPanelSettingUpDownload.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
			// 
			// FormWait
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 95);
			this.Controls.Add(this.PanelBorder);
			this.Name = "FormWait";
			this.Text = "FormWait";
			this.PanelBorder.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PanelBorder;
		private DevExpress.XtraWaitForm.ProgressPanel ProgressPanelSettingUpDownload;
	}
}