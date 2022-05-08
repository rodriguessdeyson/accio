namespace Accio.UI
{
	partial class FormMainn
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PanelAccio = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.RichTextBoxURL = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.PanelAccio.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Accio.Properties.Resources.Accio;
			this.pictureBox1.Location = new System.Drawing.Point(11, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(44, 45);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label1.Location = new System.Drawing.Point(61, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 41);
			this.label1.TabIndex = 8;
			this.label1.Text = "Accio";
			// 
			// PanelAccio
			// 
			this.PanelAccio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.PanelAccio.Controls.Add(this.groupBox1);
			this.PanelAccio.Location = new System.Drawing.Point(12, 70);
			this.PanelAccio.Name = "PanelAccio";
			this.PanelAccio.Size = new System.Drawing.Size(680, 406);
			this.PanelAccio.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RichTextBoxURL);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.groupBox1.Location = new System.Drawing.Point(17, 34);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(630, 152);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Videos Links";
			// 
			// RichTextBoxURL
			// 
			this.RichTextBoxURL.AcceptsTab = true;
			this.RichTextBoxURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.RichTextBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RichTextBoxURL.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.RichTextBoxURL.Location = new System.Drawing.Point(18, 19);
			this.RichTextBoxURL.Name = "RichTextBoxURL";
			this.RichTextBoxURL.Size = new System.Drawing.Size(592, 122);
			this.RichTextBoxURL.TabIndex = 1;
			this.RichTextBoxURL.Text = "";
			// 
			// FormMainn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.ClientSize = new System.Drawing.Size(704, 488);
			this.Controls.Add(this.PanelAccio);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMainn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Accio";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.PanelAccio.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel PanelAccio;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox RichTextBoxURL;
	}
}