using Accio.Properties;
using Accio.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Accio.UI
{
	public partial class FormDownloadVideos : XtraForm
	{
		#region Attributes

		/// <summary>
		/// Allows to manipulate the download thread.
		/// </summary>
		private Thread DownloadThreading;

		/// <summary>
		/// Flag de controle de finalização.
		/// </summary>
		private bool HasAllDownloadsFinished = false;

		/// <summary>
		/// Manipulates the download process.
		/// </summary>
		private Process DownloadProcess;

		/// <summary>
		/// Synchonization of thread.
		/// </summary>
		private bool ThreadMustSleep = false;

		/// <summary>
		/// Name of the downloading video.
		/// </summary>
		private string VideoName = string.Empty;

		/// <summary>
		/// Video url being download.
		/// </summary>
		private string VideoURL = string.Empty;

		#endregion

		#region Properties

		/// <summary>
		/// YouTube-Downloader location.
		/// </summary>
		public string DLocation { get; internal set; }

		/// <summary>
		/// List with all videos to download.
		/// </summary>
		public List<string> VideosURL { get; internal set; }

		/// <summary>
		/// Local to save the files.
		/// </summary>
		public string SavePath { get; internal set; }
		
		/// <summary>
		/// Local where the cookies file is.
		/// </summary>
		public string CookiesPath { get; internal set; }
		
		/// <summary>
		/// Flag indicating wether to use auth or not.
		/// </summary>
		public bool UseAuth { get; internal set; }

		/// <summary>
		/// Type of authentication.
		/// </summary>
		public int AuthType { get; internal set; }

		/// <summary>
		/// Username to authenticate.
		/// </summary>
		public string Username { get; internal set; }
		
		/// <summary>
		/// Password to authenticate.
		/// </summary>
		public string Password { get; internal set; }

		#endregion

		#region Enumerations

		/// <summary>
		/// Enum for buttons controls tag.
		/// </summary>
		private enum DownloadController
		{
			Skip,
			Pause,
			Stop,
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Initiate an object of type FormDownloadVideos.
		/// </summary>
		public FormDownloadVideos()
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
		private void OnFormDownloadVideosLoad(object sender, EventArgs e)
		{
			CreateTheProcessToDownload();
		}

		/// <summary>
		/// Event triggered when the link is clicked.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnHyperlinkLabelControlVideoUrelClick(object sender, EventArgs e)
		{
			if (Messages.Question("Deseja abrir o link?") == DialogResult.Yes)
				Process.Start((sender as HyperlinkLabelControl).Text);
		}

		/// <summary>
		/// Event triggered when the mouse enter the picture area.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnDownloadControlMouseEnter(object sender, EventArgs e)
		{
			// Gets who's the sender.
			PictureEdit pe = sender as PictureEdit;
			int dc = int.Parse(pe.Tag.ToString());
			switch ((DownloadController)dc)
			{
				case DownloadController.Skip:
					pe.Image = Resources.SkipHighlighted;
					break;
				case DownloadController.Pause:
					pe.Image = Resources.PauseHighlighted;
					break;
				case DownloadController.Stop:
					pe.Image = Resources.StopHighlighted;
					break;
			}
		}

		/// <summary>
		/// Event triggered when the mouse leave the picture area.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnDownloadControlMouseLeave(object sender, EventArgs e)
		{
			// Gets who's the sender.
			PictureEdit pe = sender as PictureEdit;
			int dc = int.Parse(pe.Tag.ToString());
			switch ((DownloadController)dc)
			{
				case DownloadController.Skip:
					pe.Image = Resources.Skip;
					break;
				case DownloadController.Pause:
					pe.Image = Resources.Pause;
					break;
				case DownloadController.Stop:
					pe.Image = Resources.Stop;
					break;
			}
		}

		/// <summary>
		/// Event triggered when the form is closing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Sender.</param>
		private void OnFormDownloadVideosFormClosing(object sender, FormClosingEventArgs e)
		{
			if (DownloadThreading.IsAlive)
			{
				if (Messages.Question("Os vídeos ainda estão sendo baixados. Deseja sair e parar o download?") ==
					DialogResult.Yes)
				{
					if (!DownloadProcess.HasExited)
					{
						try
						{
							DownloadProcess.Kill();
							DownloadThreading.Abort();
						}
						catch (Exception ex)
						{
							Messages.Show($"Não foi possível parar o download. {ex.Message}");
						}
					}
				}
			}
		}
		#endregion

		#region MethodsEvents

		/// <summary>
		/// Creates the threads and argumentos to download through cmd process.
		/// </summary>
		private void CreateTheProcessToDownload()
		{
			// Prepares a thread paramenters.
			DownloadThreading = new Thread(() => RunProcess())
			{
				Name = "DownloadVideo",
			};
			DownloadThreading.Start();
		}

		/// <summary>
		/// Executes the download process inside a thread.
		/// </summary>
		private void RunProcess()
		{
			// Retrieve all process arguments.
			string arguments = string.Empty;
			if (!ThreadMustSleep)
			{
				foreach (string link in VideosURL)
				{
					Invoke(new MethodInvoker(() =>
					{
						SplashScreenManager.ShowForm(this, typeof(FormWait), true, true, false, ParentFormState.Unlocked);
						SplashScreenManager.Default.SetWaitFormCaption("Aguarde!");
						SplashScreenManager.Default.SetWaitFormDescription("Obtendo informações para o download");
					}));

					if (UseAuth)
					{
						switch (AuthType)
						{
							case 0:
								arguments = $@"-o ""{SavePath}%(title)s.%(ext)s"" {link} --cookies {CookiesPath}";
								break;
							case 1:
								arguments = $@"-u {Username} -p {Password} -o ""{SavePath}%(title)s.%(ext)s"" {link}";
								break;
						}
					}
					else
						arguments = $@"-o ""{SavePath}%(title)s.%(ext)s"" {link}";

					// Update the current url.
					VideoURL = link;
					HyperlinkLabelControlVideoUrel.Invoke(new MethodInvoker(() =>
					{
						HyperlinkLabelControlVideoUrel.Text = VideoURL;
					}));

					DownloadProcess = new Process();

					// Path and file name of command to run.
					DownloadProcess.StartInfo.FileName = DLocation;

					// Arguments to run.
					DownloadProcess.StartInfo.Arguments = arguments;

					// Checks if user wants to use shell.
					DownloadProcess.StartInfo.UseShellExecute = false;

					//Set output of program to be written to process output stream
					DownloadProcess.StartInfo.RedirectStandardError = true;
					DownloadProcess.StartInfo.RedirectStandardOutput = true;
					DownloadProcess.StartInfo.RedirectStandardInput = false;
					DownloadProcess.EnableRaisingEvents = true;
					DownloadProcess.OutputDataReceived += OnProcessOutputDataReceived;
					DownloadProcess.ErrorDataReceived += OnDownloadErrorHappened;
					DownloadProcess.Exited += OnProcessFinished;
					DownloadProcess.Disposed += OnDownloadDisposed;

					// Hides the windows.
					DownloadProcess.StartInfo.CreateNoWindow = true;

					//Start the process
					DownloadProcess.Start();
					DownloadProcess.BeginErrorReadLine();
					DownloadProcess.BeginOutputReadLine();

					//Wait for process to finish
					DownloadProcess.WaitForExit();

					// Once finished, closes the process.
					DownloadProcess.Close();
					DownloadProcess.Dispose();
				}
				HasAllDownloadsFinished = true;
			}
			else
				Thread.Sleep(2000);
		}

		private void OnDownloadErrorHappened(object sender, DataReceivedEventArgs e)
		{
			SplashScreenManager.CloseForm(false);
			if (e.Data != null)
			{
				ThreadMustSleep = true;
				DialogResult r = Messages.Question($"Não foi possível obter informações do " +
					$"endereço {HyperlinkLabelControlVideoUrel.Text}. Deseja continuar o download?\n {e.Data}");
				if (r == DialogResult.Yes)
				{
					ThreadMustSleep = false;
				}
				else
				{
					try
					{
						Invoke(new MethodInvoker(() =>
						{
							DialogResult = DialogResult.Cancel;
							Close();
						}));
						DownloadThreading.Abort();
					}
					catch(Exception ex)
					{
						Messages.Show($"Não foi possível finalizar o processo: {ex.Message}");
					}
				}
			}
		}

		private void OnDownloadDisposed(object sender, EventArgs e)
		{
			// Closes this form and retun to the main one.
			ProgressBarControlDownloading.Invoke(new MethodInvoker(() =>
			{
				ProgressBarControlDownloading.EditValue = 0;
				ProgressBarControlDownloading.Refresh();
			}));
		}

		/// <summary>
		/// Event triggered when the process finished.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnProcessFinished(object sender, EventArgs e)
		{
			if (HasAllDownloadsFinished)
			{
				// Closes this form and retun to the main one.
				Invoke(new MethodInvoker(() =>
				{
					DialogResult = DialogResult.OK;
					Close();
				}));
			}
		}

		/// <summary>
		/// Event triggered everytime the process is update to update the form.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="b">Data of process.</param>
		private void OnProcessOutputDataReceived(object sender, DataReceivedEventArgs b)
		{
			Console.WriteLine(b.Data);
			double progressValue = 0;

			if (b.Data != null && b.Data.Contains("has already been downloaded"))
				return;

			// Gets the video name.
			if (b.Data != null && b.Data.StartsWith("[download] Destination:"))
			{
				var splitedContext = b.Data.Split('\\');
				VideoName = splitedContext[splitedContext.Length - 1].Trim();
				LabelControlVideoName.Invoke(new MethodInvoker(() =>
				{
					LabelControlVideoName.Visible = true;
					LabelControlVideoName.Text = $"Baixando: {VideoName}";
				}));
				LabelControlURL.Invoke(new MethodInvoker(() =>
				{
					LabelControlURL.Visible = true;
				}));
				HyperlinkLabelControlVideoUrel.Invoke(new MethodInvoker(() =>
				{
					HyperlinkLabelControlVideoUrel.Visible = true;
				}));
			}

			// Gets the progress.
			if (b.Data != null && b.Data.StartsWith("[download]"))
			{
				// Checks if the parts can be converted.
				if (b.Data.Contains("%"))
				{
					if (double
						.TryParse(b.Data.Replace(" ", string.Empty).Split('%')[0].Split(']')[1].Replace('.', ','),
						out double value) == false)
						return;

					SplashScreenManager.CloseForm(false);
					progressValue = value;
					ProgressBarControlDownloading.Invoke(new MethodInvoker(() =>
					{
						if (progressValue > ProgressBarControlDownloading.Position)
						{
							ProgressBarControlDownloading.EditValue = progressValue;
							ProgressBarControlDownloading.Refresh();
						}
					}));
				}
			}
		}

		#endregion

		private void OnProgressBarControlDownloadingCustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
		{
			e.DisplayText = e.Value.ToString();
		}
	}
}
