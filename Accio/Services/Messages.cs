using Accio.UI;
using System.Windows.Forms;

namespace Accio.Services
{
	/// <summary>
	/// Allows to create an user friendly message.
	/// </summary>
	public static class Messages
	{
		/// <summary>
		/// Shows a simple message.
		/// </summary>
		/// <param name="message">Message to be shown.</param>
		/// <param name="title">Title.</param>
		public static void Show(string message, string title = "Accio")
		{
			FormMessage MessageForm = new FormMessage
			{
				Title = title,
				Message = message,
				ButtonSet = ButtonSet.OK
			};
			MessageForm.ShowDialog();
		}

		/// <summary>
		/// Shows a question message.
		/// </summary>
		/// <param name="message">Message to be shown.</param>
		/// <param name="title">Title</param>
		/// <returns>Returns a dialogresult.</returns>
		public static DialogResult Question(string message, string title = "Accio")
		{
			FormMessage MessageForm = new FormMessage
			{
				Title = title,
				Message = message,
				ButtonSet = ButtonSet.YES_NO
			};
			return MessageForm.ShowDialog();
		}
	}
}
