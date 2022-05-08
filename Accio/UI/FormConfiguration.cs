using Accio.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Accio.UI
{
	public partial class FormConfiguration : Form
	{
		#region Attributes

		/// <summary>
		/// Allows to control the setup thread.
		/// </summary>
		private Thread SetupThread;

		/// <summary>
		/// Flag to indicate if the download finished.
		/// </summary>
		private bool HasFinished = false;

		#endregion

		#region Properties

		/// <summary>
		/// Path to save the donwload.
		/// </summary>
		public string LocalPathToSave { get; set; }

		/// <summary>
		/// File name of download.
		/// </summary>
		public string FileName { get; set; }
		#endregion

		#region Constructor

		/// <summary>
		/// Initialize an object of type FormProgress.
		/// </summary>
		public FormConfiguration()
		{
			InitializeComponent();
		}

		#endregion

		#region Events

		/// <summary>
		/// Event triggered when the form is loading.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnFormProgressLoad(object sender, EventArgs e)
		{
			// Creates a thread to download the required configuration.
			SetupThread = new Thread(() => DownloadFiles(LocalPathToSave, FileName));
			SetupThread.Start();
		}
		
		/// <summary>
		/// Event triggered when the button cancel is pressed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnSimpleButtonCancelClick(object sender, EventArgs e)
		{
			if (SetupThread.IsAlive && SetupThread.ThreadState == ThreadState.Running)
			{
				if (Messages.Question("Deseja cancelar a configuração?") == DialogResult.Yes)
				{
					SetupThread.Abort();
					SetupThread.Join();
					DialogResult = DialogResult.Abort;
					Close();
				}
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Thread method to download files.
		/// </summary>
		/// <param name="localPathToSave"></param>
		private void DownloadFiles(string localPathToSave, string fileName)
		{
			// Links to download
			List<Uri> urls = new List<Uri>
			{
				new Uri("https://youtube-dl.org/downloads/latest/youtube-dl.exe"),
				new Uri("https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.zip")
			};

			foreach (Uri uri in urls)
			{
				WebClient wc = new WebClient();
				wc.DownloadProgressChanged += OnDownloadProgressChanged;
				wc.DownloadFileCompleted += OnDownloadFileCompleted;
				wc.DownloadFileAsync(uri, Path.Combine(localPathToSave, fileName));
				while (!HasFinished);
				fileName = "ffmpeg.zip";
				HasFinished = false;

				LabelControlMessage.Invoke(new MethodInvoker(() =>
				{
					LabelControlMessage.Text = "Realizando as configurações. Aguarde!";
				}));
			}
		}

		/// <summary>
		/// Event triggered to update the download progress.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			Console.WriteLine(e.ProgressPercentage);
			ProgressBarControlDownloading.Invoke(new MethodInvoker(() =>
			{
				ProgressBarControlDownloading.EditValue = e.ProgressPercentage;
				ProgressBarControlDownloading.Refresh();
			}));
		}


		/// <summary>
		/// Event triggered when the file is completed downloading.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnDownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
		{
			string zipFile = "ffmpeg.zip";
			string targetPath = "C:\\ProgramData\\Accio\\YTDL";
			if (File.Exists(Path.Combine(targetPath, zipFile)))
			{
				HasFinished = true;

				// Unzip the file.
				ZipFile.ExtractToDirectory(Path.Combine(targetPath, zipFile), targetPath);

				// Deletes the zip file.
				File.Delete(Path.Combine(targetPath, zipFile));

				// Ends the configuration.
				Messages.Show("Aplicativo configurado com sucesso!");
				Invoke(new MethodInvoker(() =>
				{
					DialogResult = DialogResult.OK;
					Close();
				}));
				return;

			}
			HasFinished = true;
		}

		#endregion
	}
}
