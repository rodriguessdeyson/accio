using Accio.Services;
using Accio.UI;
using DevExpress.XtraEditors;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Accio
{
	public partial class FormMain : XtraForm
	{
		#region Attributes

		/// <summary>
		/// Local of the main .exe.
		/// </summary>
		private readonly string PathFolder = "C:\\ProgramData\\Accio\\YTDL";

		/// <summary>
		/// Name of the main .exe.
		/// </summary>
		private readonly string FileName = "youtube-dl.exe";

		#endregion

		#region Properties

		/// <summary>
		/// Video name.
		/// </summary>
		public string VideoName { get; set; } = "Accio";

		/// <summary>
		/// Video size.
		/// </summary>
		public double VideoSize { get; set; }
		#endregion

		#region Constructor

		public FormMain()
		{
			InitializeComponent();
		}

		#endregion

		#region Events

		/// <summary>
		/// Event triggered when the form is closing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnSimpleButtonCloseClick(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Event triggered when the button to minimize is pressed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnSimpleButtonMinimizeClick(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		/// <summary>
		/// Event triggered when the check changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnCheckEditAuthCheckedChanged(object sender, EventArgs e)
		{
			RadioGroupAuthentication.Enabled = ((CheckEdit)sender).Checked;
			EnableDisableAuthParameters(false);
			TextEditUsername.EditValue = string.Empty;
			TextEditPassword.EditValue = string.Empty;
			SimpleButtonSelectCookieFile.Enabled = ((CheckEdit)sender).Checked;
		}

		/// <summary>
		/// Event triggered when the radio changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnRadioGroupAuthenticationSelectedIndexChanged(object sender, EventArgs e)
		{
			RadioGroup rg = sender as RadioGroup;
			if (int.Parse(rg.EditValue.ToString()) == 0)
			{
				EnableDisableAuthParameters(true);
				SimpleButtonSelectCookieFile.Enabled = false;
			}
			else
			{
				EnableDisableAuthParameters(false);
				TextEditUsername.EditValue = string.Empty;
				TextEditPassword.EditValue = string.Empty;
				SimpleButtonSelectCookieFile.Enabled = true;

			}
		}

		/// <summary>
		/// Event triggered when the select path button is pressed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnSimpleButtonSelectFolderClick(object sender, EventArgs e)
		{
			string dir = TextEditSelectedFolder.Text ?? "C:\\Users";
			CommonOpenFileDialog dialog = new CommonOpenFileDialog()
			{
				InitialDirectory = dir,
				IsFolderPicker = true,
			};

			if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
				TextEditSelectedFolder.Text = $@"{dialog.FileName}\";
		}

		/// <summary>
		/// Event triggered when the select cookies button is pressed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnSimpleButtonSelectCookieFileClick(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				InitialDirectory = "C:\\Users",
				Filter = "Arquivo txt(*.txt)|*.txt",
				FilterIndex = 0,
				RestoreDirectory = true
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				//Get the path of specified file
				TextEditSelectedCookieFile.Text = openFileDialog.FileName;
			}
		}

		/// <summary>
		/// Event triggered when the download button is pressed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnSimpleButtonDownloadClick(object sender, EventArgs e)
		{
			// Validates the urls.
			if (!ValidateUrls(out string invalidUrl))
			{
				Messages.Show($@"O endereço ""{invalidUrl}"" é inválido. Certifique-se que o endereço é HTTP/HTTPS");
				return;
			}

			// Checks if the output folder was selected.
			if (string.IsNullOrWhiteSpace(TextEditSelectedFolder.Text))
			{
				Messages.Show("Selecione um local para salvar os vídeos");
				return;
			}

			// Checks if the authentication is through cookies file.
			if (CheckEditAuth.Checked && RadioGroupAuthentication.SelectedIndex == 0 &&
				string.IsNullOrWhiteSpace(TextEditSelectedCookieFile.Text))
			{
				Messages.Show("Selecione o arquivo .txt com os dados de cookies.");
				return;
			}

			// Once validated all informations, pass to the controller of download.
			FormDownloadVideos dv = new FormDownloadVideos
			{
				VideosURL   = RichTextBoxURL.Text.Split('\n').ToList(),
				DLocation   = Path.Combine(PathFolder, FileName),
				UseAuth     = CheckEditAuth.Checked,
				AuthType    = RadioGroupAuthentication.SelectedIndex,
				SavePath    = TextEditSelectedFolder.Text,
				CookiesPath = TextEditSelectedCookieFile.Text,
				Username    = TextEditUsername.Text,
				Password    = TextEditPassword.Text,
			};
			SimpleButtonDownload.Enabled = false;
			if (dv.ShowDialog(this) == DialogResult.OK)
			{
				Messages.Show("Download realizado com sucesso!");
			}
			else
			{
				Messages.Show("Download cancelado.");
			}
			SimpleButtonDownload.Enabled = true;
		}

		/// <summary>
		/// Event triggered when the theme button is pressed. (Is disabled now).
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnSimpleButtonThemeClick(object sender, EventArgs e)
		{
			// Updates the theme.
			BackColor = Color.FromArgb(250, 250, 250);
			PanelAccio.BackColor = Color.FromArgb(250, 250, 250);
			RichTextBoxURL.BackColor = Color.White;
			RichTextBoxURL.BorderStyle = BorderStyle.FixedSingle;
			SimpleButtonTheme.Appearance.BackColor = Color.FromArgb(250, 250, 250);
			SimpleButtonMinimize.Appearance.BackColor = Color.FromArgb(250, 250, 250);
			SimpleButtonClose.Appearance.BackColor = Color.FromArgb(250, 250, 250);
			RadioGroupAuthentication.BackColor = Color.FromArgb(250, 250, 250);
		}

		/// <summary>
		/// Event triggered when the Rich text has its value changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnRichTextBoxURLTextChanged(object sender, EventArgs e)
		{
			// Checks if there's text.
			RichTextBox tx = sender as RichTextBox;
			SimpleButtonDownload.Enabled = !string.IsNullOrWhiteSpace(tx.Text) && ValidateUrls(out _);
		}

		/// <summary>
		/// Event triggered when the form is about to close.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnFormMainFormClosing(object sender, FormClosingEventArgs e)
		{
			if (Messages.Question("Desaja finalizar o programa?") != DialogResult.Yes)
				e.Cancel = true;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Enable and disable auth paramenters.
		/// </summary>
		/// <param name="isEnable">True to enable. False to disable.</param>
		private void EnableDisableAuthParameters(bool isEnable)
		{
			LabelControlUser.Enabled = isEnable;
			LabelControlPassword.Enabled = isEnable;
			TextEditUsername.Enabled = isEnable;
			TextEditPassword.Enabled = isEnable;
		}

		/// <summary>
		/// Validates links.
		/// </summary>
		/// <param name="invalidUrl">Invalid url detected.</param>
		/// <returns>True if all the urls are ok. False, otherwise.</returns>
		private bool ValidateUrls(out string invalidUrl)
		{
			invalidUrl = string.Empty;
			List<string> links = RichTextBoxURL.Text.Split('\n').ToList();
			foreach (string url in links)
			{
				bool result = Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
				&& (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
				invalidUrl = url;
				if (result == false)
					return false;
			}
			return true;
		}
		
		#endregion

		/// <summary>
		/// Event triggered when the form is loading.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnFormMainLoad(object sender, EventArgs e)
		{
			// Checks if all system is setup.
			if (!File.Exists(Path.Combine(PathFolder, FileName)))
			{
				DialogResult dr = Messages
					.Question("Uma configuração é necessária para a utilização do aplicativo.\n\nDeseja continuar?");
				if (dr != DialogResult.Yes)
				{
					Close();
					return;
				}

				// Creates the directory.
				Directory.CreateDirectory(PathFolder);

				// Initiate the download process.
				FormConfiguration pProcess = new FormConfiguration
				{
					LocalPathToSave = PathFolder,
					FileName = FileName,
				};

				// Checks the dialog result.
				switch (pProcess.ShowDialog())
				{
					case DialogResult.Abort:
						Messages.Show("A configuração foi cancelada.");
						Directory.Delete(PathFolder);
						Close();
						return;
				}
			}
		}

		private void OnRichTextBoxURLLinkClicked(object sender, LinkClickedEventArgs e)
		{
			if (Messages.Question("Deseja abrir o site?") != DialogResult.Yes)
				return;
			Process.Start(e.LinkText);
		}
	}
}
