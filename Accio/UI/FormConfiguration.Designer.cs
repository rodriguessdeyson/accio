namespace Accio.UI
{
	partial class FormConfiguration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguration));
			this.PanelBorder = new System.Windows.Forms.Panel();
			this.ProgressBarControlDownloading = new DevExpress.XtraEditors.ProgressBarControl();
			this.LabelControlMessage = new DevExpress.XtraEditors.LabelControl();
			this.SeparatorControlAuth = new DevExpress.XtraEditors.SeparatorControl();
			this.SimpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControlTitle = new DevExpress.XtraEditors.LabelControl();
			this.PanelBorder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProgressBarControlDownloading.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SeparatorControlAuth)).BeginInit();
			this.SuspendLayout();
			// 
			// PanelBorder
			// 
			this.PanelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelBorder.Controls.Add(this.ProgressBarControlDownloading);
			this.PanelBorder.Controls.Add(this.LabelControlMessage);
			this.PanelBorder.Controls.Add(this.SeparatorControlAuth);
			this.PanelBorder.Controls.Add(this.SimpleButtonCancel);
			this.PanelBorder.Controls.Add(this.LabelControlTitle);
			this.PanelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelBorder.Location = new System.Drawing.Point(0, 0);
			this.PanelBorder.Name = "PanelBorder";
			this.PanelBorder.Size = new System.Drawing.Size(338, 162);
			this.PanelBorder.TabIndex = 11;
			// 
			// ProgressBarControlDownloading
			// 
			this.ProgressBarControlDownloading.Location = new System.Drawing.Point(12, 91);
			this.ProgressBarControlDownloading.Name = "ProgressBarControlDownloading";
			// 
			// 
			// 
			this.ProgressBarControlDownloading.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
			this.ProgressBarControlDownloading.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(238)))));
			this.ProgressBarControlDownloading.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.ProgressBarControlDownloading.Size = new System.Drawing.Size(314, 21);
			this.ProgressBarControlDownloading.TabIndex = 10;
			// 
			// LabelControlMessage
			// 
			this.LabelControlMessage.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.LabelControlMessage.Appearance.Options.UseForeColor = true;
			this.LabelControlMessage.Appearance.Options.UseTextOptions = true;
			this.LabelControlMessage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.LabelControlMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.LabelControlMessage.Location = new System.Drawing.Point(27, 58);
			this.LabelControlMessage.Name = "LabelControlMessage";
			this.LabelControlMessage.Size = new System.Drawing.Size(284, 13);
			this.LabelControlMessage.TabIndex = 9;
			this.LabelControlMessage.Text = "Realizando os downloads necessários para a aplicação.";
			// 
			// SeparatorControlAuth
			// 
			this.SeparatorControlAuth.BackColor = System.Drawing.SystemColors.ControlDark;
			this.SeparatorControlAuth.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.SeparatorControlAuth.Location = new System.Drawing.Point(7, 37);
			this.SeparatorControlAuth.Name = "SeparatorControlAuth";
			this.SeparatorControlAuth.Size = new System.Drawing.Size(325, 1);
			this.SeparatorControlAuth.TabIndex = 8;
			// 
			// SimpleButtonCancel
			// 
			this.SimpleButtonCancel.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("SimpleButtonCancel.Appearance.BackColor")));
			this.SimpleButtonCancel.Appearance.Options.UseBackColor = true;
			this.SimpleButtonCancel.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
			this.SimpleButtonCancel.AppearanceDisabled.Options.UseBackColor = true;
			this.SimpleButtonCancel.AppearancePressed.BackColor = System.Drawing.Color.LightGreen;
			this.SimpleButtonCancel.AppearancePressed.Options.UseBackColor = true;
			this.SimpleButtonCancel.Location = new System.Drawing.Point(248, 127);
			this.SimpleButtonCancel.Name = "SimpleButtonCancel";
			this.SimpleButtonCancel.Size = new System.Drawing.Size(77, 23);
			this.SimpleButtonCancel.TabIndex = 6;
			this.SimpleButtonCancel.Text = "Cancelar";
			this.SimpleButtonCancel.Click += new System.EventHandler(this.OnSimpleButtonCancelClick);
			// 
			// LabelControlTitle
			// 
			this.LabelControlTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.LabelControlTitle.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.LabelControlTitle.Appearance.Options.UseFont = true;
			this.LabelControlTitle.Appearance.Options.UseForeColor = true;
			this.LabelControlTitle.Location = new System.Drawing.Point(7, 12);
			this.LabelControlTitle.Name = "LabelControlTitle";
			this.LabelControlTitle.Size = new System.Drawing.Size(38, 19);
			this.LabelControlTitle.TabIndex = 7;
			this.LabelControlTitle.Text = "Accio";
			// 
			// FormConfiguration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
			this.ClientSize = new System.Drawing.Size(338, 162);
			this.Controls.Add(this.PanelBorder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormConfiguration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormProgress";
			this.Load += new System.EventHandler(this.OnFormProgressLoad);
			this.PanelBorder.ResumeLayout(false);
			this.PanelBorder.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProgressBarControlDownloading.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SeparatorControlAuth)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PanelBorder;
		private DevExpress.XtraEditors.LabelControl LabelControlMessage;
		private DevExpress.XtraEditors.SeparatorControl SeparatorControlAuth;
		private DevExpress.XtraEditors.SimpleButton SimpleButtonCancel;
		private DevExpress.XtraEditors.LabelControl LabelControlTitle;
		public DevExpress.XtraEditors.ProgressBarControl ProgressBarControlDownloading;
	}
}