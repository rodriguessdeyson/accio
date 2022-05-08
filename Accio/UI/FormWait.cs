using DevExpress.XtraWaitForm;
using System;

namespace Accio.UI
{
	/// <summary>
	/// Allows to create an object of type FormWait.
	/// </summary>
	public partial class FormWait : WaitForm
	{
		#region Constructor

		/// <summary>
		/// Initiates an objetct of type FormWait.
		/// </summary>
		public FormWait()
		{
			InitializeComponent();
		}

		#endregion

		#region BaseOverride

		/// <summary>
		/// Sets the caption of wait form.
		/// </summary>
		/// <param name="caption">Name of caption.</param>
		public override void SetCaption(string caption)
		{
			base.SetCaption(caption);
			ProgressPanelSettingUpDownload.Caption = caption;
		}

		/// <summary>
		/// Sets the description of wait form.
		/// </summary>
		/// <param name="description">Description to show.</param>
		public override void SetDescription(string description)
		{
			base.SetDescription(description);
			ProgressPanelSettingUpDownload.Description = description;
		}

		public override void ProcessCommand(Enum cmd, object arg)
		{
			base.ProcessCommand(cmd, arg);
		}

		#endregion
	}
}
