namespace Accio.UI
{
	partial class FormMessage
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
			this.SimpleButtonRight = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControlTitle = new DevExpress.XtraEditors.LabelControl();
			this.SeparatorControlAuth = new DevExpress.XtraEditors.SeparatorControl();
			this.SimpleButtonLeft = new DevExpress.XtraEditors.SimpleButton();
			this.PanelBorder = new System.Windows.Forms.Panel();
			this.LabelControlMessage = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.SeparatorControlAuth)).BeginInit();
			this.PanelBorder.SuspendLayout();
			this.SuspendLayout();
			// 
			// SimpleButtonRight
			// 
			this.SimpleButtonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SimpleButtonRight.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
			this.SimpleButtonRight.Appearance.Options.UseBackColor = true;
			this.SimpleButtonRight.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
			this.SimpleButtonRight.AppearanceDisabled.Options.UseBackColor = true;
			this.SimpleButtonRight.AppearancePressed.BackColor = System.Drawing.Color.LightGreen;
			this.SimpleButtonRight.AppearancePressed.Options.UseBackColor = true;
			this.SimpleButtonRight.Location = new System.Drawing.Point(262, 141);
			this.SimpleButtonRight.Name = "SimpleButtonRight";
			this.SimpleButtonRight.Size = new System.Drawing.Size(58, 23);
			this.SimpleButtonRight.TabIndex = 6;
			this.SimpleButtonRight.Text = "Cancelar";
			this.SimpleButtonRight.Click += new System.EventHandler(this.OnSimpleButtonRightClick);
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
			// SeparatorControlAuth
			// 
			this.SeparatorControlAuth.BackColor = System.Drawing.SystemColors.ControlDark;
			this.SeparatorControlAuth.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.SeparatorControlAuth.Location = new System.Drawing.Point(7, 37);
			this.SeparatorControlAuth.Name = "SeparatorControlAuth";
			this.SeparatorControlAuth.Size = new System.Drawing.Size(313, 1);
			this.SeparatorControlAuth.TabIndex = 8;
			// 
			// SimpleButtonLeft
			// 
			this.SimpleButtonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SimpleButtonLeft.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
			this.SimpleButtonLeft.Appearance.Options.UseBackColor = true;
			this.SimpleButtonLeft.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
			this.SimpleButtonLeft.AppearanceDisabled.Options.UseBackColor = true;
			this.SimpleButtonLeft.AppearancePressed.BackColor = System.Drawing.Color.LightGreen;
			this.SimpleButtonLeft.AppearancePressed.Options.UseBackColor = true;
			this.SimpleButtonLeft.Location = new System.Drawing.Point(198, 141);
			this.SimpleButtonLeft.Name = "SimpleButtonLeft";
			this.SimpleButtonLeft.Size = new System.Drawing.Size(58, 23);
			this.SimpleButtonLeft.TabIndex = 6;
			this.SimpleButtonLeft.Text = "OK";
			this.SimpleButtonLeft.Click += new System.EventHandler(this.OnSimpleButtonLeftClick);
			// 
			// PanelBorder
			// 
			this.PanelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelBorder.Controls.Add(this.LabelControlMessage);
			this.PanelBorder.Controls.Add(this.SimpleButtonLeft);
			this.PanelBorder.Controls.Add(this.SeparatorControlAuth);
			this.PanelBorder.Controls.Add(this.SimpleButtonRight);
			this.PanelBorder.Controls.Add(this.LabelControlTitle);
			this.PanelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelBorder.Location = new System.Drawing.Point(0, 0);
			this.PanelBorder.Name = "PanelBorder";
			this.PanelBorder.Size = new System.Drawing.Size(333, 177);
			this.PanelBorder.TabIndex = 10;
			// 
			// LabelControlMessage
			// 
			this.LabelControlMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelControlMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
			this.LabelControlMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LabelControlMessage.ForeColor = System.Drawing.Color.Gray;
			this.LabelControlMessage.Location = new System.Drawing.Point(7, 54);
			this.LabelControlMessage.Multiline = true;
			this.LabelControlMessage.Name = "LabelControlMessage";
			this.LabelControlMessage.ReadOnly = true;
			this.LabelControlMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.LabelControlMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.LabelControlMessage.Size = new System.Drawing.Size(313, 81);
			this.LabelControlMessage.TabIndex = 10;
			// 
			// FormMessage
			// 
			this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(333, 177);
			this.Controls.Add(this.PanelBorder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMessage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Message";
			this.Load += new System.EventHandler(this.OnMessageLoad);
			((System.ComponentModel.ISupportInitialize)(this.SeparatorControlAuth)).EndInit();
			this.PanelBorder.ResumeLayout(false);
			this.PanelBorder.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton SimpleButtonRight;
		private DevExpress.XtraEditors.LabelControl LabelControlTitle;
		private DevExpress.XtraEditors.SeparatorControl SeparatorControlAuth;
		private DevExpress.XtraEditors.SimpleButton SimpleButtonLeft;
		private System.Windows.Forms.Panel PanelBorder;
		private System.Windows.Forms.TextBox LabelControlMessage;
	}
}