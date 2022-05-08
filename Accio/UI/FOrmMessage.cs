using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Accio.UI
{
	#region Enumerations

	/// <summary>
	/// Sets of button to be shown on form.
	/// </summary>
	public enum ButtonSet
	{
		OK_CANCEL,
		YES_NO,
		OK,
	}

	#endregion

	/// <summary>
	/// Allow to create a new messagebox structure.
	/// </summary>
	public partial class FormMessage : XtraForm
	{
		#region Properties

		/// <summary>
		/// Title of Message to be shown.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Message to shown.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Set of buttons to be shown.
		/// </summary>
		public ButtonSet ButtonSet { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Inititate an object of FormMessage.
		/// </summary>
		public FormMessage()
		{
			InitializeComponent();
		}
		
		#endregion

		private void OnMessageLoad(object sender, EventArgs e)
		{
			LabelControlTitle.Text = Title;
			LabelControlMessage.Text = Message;

			// Configure the buttons.
			switch (ButtonSet)
			{
				case ButtonSet.OK_CANCEL:
					SimpleButtonLeft.Text = "OK";
					SimpleButtonRight.Text = "Cancelar";
					break;
				case ButtonSet.YES_NO:
					SimpleButtonLeft.Text = "Sim";
					SimpleButtonRight.Text = "Não";
					break;
				case ButtonSet.OK:
					SimpleButtonLeft.Visible = false;
					SimpleButtonRight.Text = "OK";
					break;
			}
		}

		/// <summary>
		/// Event triggered when the right button is pressed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnSimpleButtonRightClick(object sender, EventArgs e)
		{
			switch (ButtonSet)
			{
				case ButtonSet.OK_CANCEL:
					DialogResult = DialogResult.Cancel;
					Close();
					break;
				case ButtonSet.YES_NO:
					DialogResult = DialogResult.No;
					Close();
					break;
				case ButtonSet.OK:
					DialogResult = DialogResult.OK;
					Close();
					break;
			}
		}

		/// <summary>
		/// Event triggered when the left button is pressed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event.</param>
		private void OnSimpleButtonLeftClick(object sender, EventArgs e)
		{
			switch (ButtonSet)
			{
				case ButtonSet.OK_CANCEL:
					DialogResult = DialogResult.OK;
					Close();
					break;
				case ButtonSet.YES_NO:
					DialogResult = DialogResult.Yes;
					Close();
					break;
			}
		}
	}
}
