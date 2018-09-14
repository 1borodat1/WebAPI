using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.TextProcessing
{
	public class BaseTextProcessing : ITextProcessing
	{

		#region Fields: Private

		private List<ITextProcessing> TextProcessings;

		#endregion

		#region Properties: Public
		
		/// <summary>
		/// Is enabled another text processing.
		/// </summary>
		public bool UseProcessing {
			get; set;
		}

		#endregion

		#region Constructor: Public

		public BaseTextProcessing() {
			Initialize();
		}

		#endregion

		#region Methods: Private

		/// <summary>
		/// Initialize class props.
		/// </summary>
		/// <param name="textProcessing">Another text procesing.</param>
		private void Initialize() {
			TextProcessings = new List<ITextProcessing>();
			UseProcessing = true;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Execute another text preprocessings.
		/// </summary>
		/// <param name="textProcessing">Text to process.</param>
		protected virtual string ExecuteAnotherTextProcessing(string text) {
			string textAfterAnotherProcessing = text;
			if (UseProcessing && TextProcessings.Any()) {
				foreach (var textProcess in TextProcessings) {
					textAfterAnotherProcessing = textProcess.Process(textAfterAnotherProcessing);
				}
			}
			return textAfterAnotherProcessing;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Main text processing.
		/// </summary>
		/// <param name="text">Text to process.</param>
		public virtual string Process(string text) {
			return ExecuteAnotherTextProcessing(text);
		}

		/// <summary>
		/// Add another text preprocessings.
		/// </summary>
		/// <param name="textProcessing">Another text preprocessing.</param>
		public virtual void AddTextProcessing(ITextProcessing textProcessing) {
			if (textProcessing == null) {
				return;
			}
			TextProcessings.Add(textProcessing);
		}

		#endregion
	}
}
