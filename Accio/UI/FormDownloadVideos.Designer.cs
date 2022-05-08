namespace Accio.UI
{
	partial class FormDownloadVideos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDownloadVideos));
			this.PanelBorder = new System.Windows.Forms.Panel();
			this.SimpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
			this.PictureEditSkipCurrentDownload = new DevExpress.XtraEditors.PictureEdit();
			this.PictureEditPauseDownload = new DevExpress.XtraEditors.PictureEdit();
			this.PictureEditStopDownload = new DevExpress.XtraEditors.PictureEdit();
			this.LabelControlAuth = new DevExpress.XtraEditors.LabelControl();
			this.PanelDownloadProgress = new System.Windows.Forms.Panel();
			this.ProgressBarControlDownloading = new DevExpress.XtraEditors.ProgressBarControl();
			this.HyperlinkLabelControlVideoUrel = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.LabelControlVideoName = new DevExpress.XtraEditors.LabelControl();
			this.LabelControlURL = new DevExpress.XtraEditors.LabelControl();
			this.SeparatorControlAuth = new DevExpress.XtraEditors.SeparatorControl();
			this.LabelControlTitle = new DevExpress.XtraEditors.LabelControl();
			this.PanelBorder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureEditSkipCurrentDownload.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureEditPauseDownload.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureEditStopDownload.Properties)).BeginInit();
			this.PanelDownloadProgress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProgressBarControlDownloading.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SeparatorControlAuth)).BeginInit();
			this.SuspendLayout();
			// 
			// PanelBorder
			// 
			this.PanelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelBorder.Controls.Add(this.SimpleButtonClose);
			this.PanelBorder.Controls.Add(this.PictureEditSkipCurrentDownload);
			this.PanelBorder.Controls.Add(this.PictureEditPauseDownload);
			this.PanelBorder.Controls.Add(this.PictureEditStopDownload);
			this.PanelBorder.Controls.Add(this.LabelControlAuth);
			this.PanelBorder.Controls.Add(this.PanelDownloadProgress);
			this.PanelBorder.Controls.Add(this.SeparatorControlAuth);
			this.PanelBorder.Controls.Add(this.LabelControlTitle);
			this.PanelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelBorder.Location = new System.Drawing.Point(0, 0);
			this.PanelBorder.Name = "PanelBorder";
			this.PanelBorder.Size = new System.Drawing.Size(482, 225);
			this.PanelBorder.TabIndex = 12;
			// 
			// SimpleButtonClose
			// 
			this.SimpleButtonClose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
			this.SimpleButtonClose.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
			this.SimpleButtonClose.Appearance.Options.UseBackColor = true;
			this.SimpleButtonClose.Appearance.Options.UseBorderColor = true;
			this.SimpleButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.SimpleButtonClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
			this.SimpleButtonClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SimpleButtonClose.ImageOptions.SvgImage")));
			this.SimpleButtonClose.Location = new System.Drawing.Point(437, 3);
			this.SimpleButtonClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
			this.SimpleButtonClose.LookAndFeel.UseDefaultLookAndFeel = false;
			this.SimpleButtonClose.Name = "SimpleButtonClose";
			this.SimpleButtonClose.Size = new System.Drawing.Size(32, 32);
			this.SimpleButtonClose.TabIndex = 13;
			// 
			// PictureEditSkipCurrentDownload
			// 
			this.PictureEditSkipCurrentDownload.EditValue = global::Accio.Properties.Resources.Skip;
			this.PictureEditSkipCurrentDownload.Location = new System.Drawing.Point(327, 175);
			this.PictureEditSkipCurrentDownload.Name = "PictureEditSkipCurrentDownload";
			this.PictureEditSkipCurrentDownload.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
			this.PictureEditSkipCurrentDownload.Properties.Appearance.Options.UseBackColor = true;
			this.PictureEditSkipCurrentDownload.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.PictureEditSkipCurrentDownload.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.PictureEditSkipCurrentDownload.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
			this.PictureEditSkipCurrentDownload.Size = new System.Drawing.Size(40, 40);
			this.PictureEditSkipCurrentDownload.TabIndex = 12;
			this.PictureEditSkipCurrentDownload.Tag = "0";
			this.PictureEditSkipCurrentDownload.ToolTipTitle = "Pular para o próximo download";
			this.PictureEditSkipCurrentDownload.MouseEnter += new System.EventHandler(this.OnDownloadControlMouseEnter);
			this.PictureEditSkipCurrentDownload.MouseLeave += new System.EventHandler(this.OnDownloadControlMouseLeave);
			// 
			// PictureEditPauseDownload
			// 
			this.PictureEditPauseDownload.EditValue = global::Accio.Properties.Resources.Pause;
			this.PictureEditPauseDownload.Location = new System.Drawing.Point(378, 175);
			this.PictureEditPauseDownload.Name = "PictureEditPauseDownload";
			this.PictureEditPauseDownload.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
			this.PictureEditPauseDownload.Properties.Appearance.Options.UseBackColor = true;
			this.PictureEditPauseDownload.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.PictureEditPauseDownload.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.PictureEditPauseDownload.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
			this.PictureEditPauseDownload.Size = new System.Drawing.Size(40, 40);
			this.PictureEditPauseDownload.TabIndex = 12;
			this.PictureEditPauseDownload.Tag = "1";
			this.PictureEditPauseDownload.ToolTipTitle = "Pausar o download atual";
			this.PictureEditPauseDownload.MouseEnter += new System.EventHandler(this.OnDownloadControlMouseEnter);
			this.PictureEditPauseDownload.MouseLeave += new System.EventHandler(this.OnDownloadControlMouseLeave);
			// 
			// PictureEditStopDownload
			// 
			this.PictureEditStopDownload.EditValue = global::Accio.Properties.Resources.Stop;
			this.PictureEditStopDownload.Location = new System.Drawing.Point(429, 175);
			this.PictureEditStopDownload.Name = "PictureEditStopDownload";
			this.PictureEditStopDownload.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
			this.PictureEditStopDownload.Properties.Appearance.Options.UseBackColor = true;
			this.PictureEditStopDownload.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.PictureEditStopDownload.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.PictureEditStopDownload.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
			this.PictureEditStopDownload.Size = new System.Drawing.Size(40, 40);
			this.PictureEditStopDownload.TabIndex = 12;
			this.PictureEditStopDownload.Tag = "2";
			this.PictureEditStopDownload.ToolTipTitle = "Parar o download";
			this.PictureEditStopDownload.MouseEnter += new System.EventHandler(this.OnDownloadControlMouseEnter);
			this.PictureEditStopDownload.MouseLeave += new System.EventHandler(this.OnDownloadControlMouseLeave);
			// 
			// LabelControlAuth
			// 
			this.LabelControlAuth.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelControlAuth.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.LabelControlAuth.Appearance.Options.UseFont = true;
			this.LabelControlAuth.Appearance.Options.UseForeColor = true;
			this.LabelControlAuth.Location = new System.Drawing.Point(13, 52);
			this.LabelControlAuth.Name = "LabelControlAuth";
			this.LabelControlAuth.Size = new System.Drawing.Size(142, 16);
			this.LabelControlAuth.TabIndex = 10;
			this.LabelControlAuth.Text = "Informação do download";
			// 
			// PanelDownloadProgress
			// 
			this.PanelDownloadProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.PanelDownloadProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelDownloadProgress.Controls.Add(this.ProgressBarControlDownloading);
			this.PanelDownloadProgress.Controls.Add(this.HyperlinkLabelControlVideoUrel);
			this.PanelDownloadProgress.Controls.Add(this.LabelControlVideoName);
			this.PanelDownloadProgress.Controls.Add(this.LabelControlURL);
			this.PanelDownloadProgress.Location = new System.Drawing.Point(13, 83);
			this.PanelDownloadProgress.Name = "PanelDownloadProgress";
			this.PanelDownloadProgress.Size = new System.Drawing.Size(451, 86);
			this.PanelDownloadProgress.TabIndex = 11;
			// 
			// ProgressBarControlDownloading
			// 
			this.ProgressBarControlDownloading.Location = new System.Drawing.Point(9, 59);
			this.ProgressBarControlDownloading.Name = "ProgressBarControlDownloading";
			this.ProgressBarControlDownloading.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
			this.ProgressBarControlDownloading.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.ProgressBarControlDownloading.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.ProgressBarControlDownloading.Properties.ShowTitle = true;
			this.ProgressBarControlDownloading.Properties.Step = 1;
			this.ProgressBarControlDownloading.Size = new System.Drawing.Size(433, 17);
			this.ProgressBarControlDownloading.TabIndex = 12;
			this.ProgressBarControlDownloading.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.OnProgressBarControlDownloadingCustomDisplayText);
			// 
			// HyperlinkLabelControlVideoUrel
			// 
			this.HyperlinkLabelControlVideoUrel.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
			this.HyperlinkLabelControlVideoUrel.Appearance.Options.UseLinkColor = true;
			this.HyperlinkLabelControlVideoUrel.Appearance.Options.UsePressedColor = true;
			this.HyperlinkLabelControlVideoUrel.Appearance.Options.UseVisitedColor = true;
			this.HyperlinkLabelControlVideoUrel.Appearance.PressedColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
			this.HyperlinkLabelControlVideoUrel.Appearance.VisitedColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
			this.HyperlinkLabelControlVideoUrel.Location = new System.Drawing.Point(46, 35);
			this.HyperlinkLabelControlVideoUrel.Name = "HyperlinkLabelControlVideoUrel";
			this.HyperlinkLabelControlVideoUrel.Size = new System.Drawing.Size(83, 13);
			this.HyperlinkLabelControlVideoUrel.TabIndex = 11;
			this.HyperlinkLabelControlVideoUrel.Text = "www.google.com";
			this.HyperlinkLabelControlVideoUrel.Visible = false;
			this.HyperlinkLabelControlVideoUrel.Click += new System.EventHandler(this.OnHyperlinkLabelControlVideoUrelClick);
			// 
			// LabelControlVideoName
			// 
			this.LabelControlVideoName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelControlVideoName.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.LabelControlVideoName.Appearance.Options.UseFont = true;
			this.LabelControlVideoName.Appearance.Options.UseForeColor = true;
			this.LabelControlVideoName.Location = new System.Drawing.Point(13, 9);
			this.LabelControlVideoName.Name = "LabelControlVideoName";
			this.LabelControlVideoName.Size = new System.Drawing.Size(37, 16);
			this.LabelControlVideoName.TabIndex = 10;
			this.LabelControlVideoName.Text = "Vídeo:";
			this.LabelControlVideoName.Visible = false;
			// 
			// LabelControlURL
			// 
			this.LabelControlURL.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelControlURL.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.LabelControlURL.Appearance.Options.UseFont = true;
			this.LabelControlURL.Appearance.Options.UseForeColor = true;
			this.LabelControlURL.Location = new System.Drawing.Point(13, 33);
			this.LabelControlURL.Name = "LabelControlURL";
			this.LabelControlURL.Size = new System.Drawing.Size(27, 16);
			this.LabelControlURL.TabIndex = 10;
			this.LabelControlURL.Text = "URL:";
			this.LabelControlURL.Visible = false;
			// 
			// SeparatorControlAuth
			// 
			this.SeparatorControlAuth.BackColor = System.Drawing.SystemColors.ControlDark;
			this.SeparatorControlAuth.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.SeparatorControlAuth.Location = new System.Drawing.Point(5, 37);
			this.SeparatorControlAuth.Name = "SeparatorControlAuth";
			this.SeparatorControlAuth.Size = new System.Drawing.Size(464, 1);
			this.SeparatorControlAuth.TabIndex = 8;
			// 
			// LabelControlTitle
			// 
			this.LabelControlTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.LabelControlTitle.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.LabelControlTitle.Appearance.Options.UseFont = true;
			this.LabelControlTitle.Appearance.Options.UseForeColor = true;
			this.LabelControlTitle.Location = new System.Drawing.Point(11, 12);
			this.LabelControlTitle.Name = "LabelControlTitle";
			this.LabelControlTitle.Size = new System.Drawing.Size(38, 19);
			this.LabelControlTitle.TabIndex = 7;
			this.LabelControlTitle.Text = "Accio";
			// 
			// FormDownloadVideos
			// 
			this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.SimpleButtonClose;
			this.ClientSize = new System.Drawing.Size(482, 225);
			this.Controls.Add(this.PanelBorder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormDownloadVideos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormDownloadVideos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormDownloadVideosFormClosing);
			this.Load += new System.EventHandler(this.OnFormDownloadVideosLoad);
			this.PanelBorder.ResumeLayout(false);
			this.PanelBorder.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureEditSkipCurrentDownload.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureEditPauseDownload.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureEditStopDownload.Properties)).EndInit();
			this.PanelDownloadProgress.ResumeLayout(false);
			this.PanelDownloadProgress.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProgressBarControlDownloading.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SeparatorControlAuth)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PanelBorder;
		private DevExpress.XtraEditors.SeparatorControl SeparatorControlAuth;
		private DevExpress.XtraEditors.LabelControl LabelControlTitle;
		private DevExpress.XtraEditors.LabelControl LabelControlAuth;
		private System.Windows.Forms.Panel PanelDownloadProgress;
		private DevExpress.XtraEditors.ProgressBarControl ProgressBarControlDownloading;
		private DevExpress.XtraEditors.HyperlinkLabelControl HyperlinkLabelControlVideoUrel;
		private DevExpress.XtraEditors.LabelControl LabelControlVideoName;
		private DevExpress.XtraEditors.LabelControl LabelControlURL;
		private DevExpress.XtraEditors.PictureEdit PictureEditSkipCurrentDownload;
		private DevExpress.XtraEditors.PictureEdit PictureEditPauseDownload;
		private DevExpress.XtraEditors.PictureEdit PictureEditStopDownload;
		private DevExpress.XtraEditors.SimpleButton SimpleButtonClose;
	}
}