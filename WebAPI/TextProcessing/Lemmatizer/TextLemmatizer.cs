namespace WebAPI.TextProcessing
{
	using System;
	using System.Text;

	#region Class: TextLemmatizator

	public class TextLemmatizer: BaseTextProcessing
	{

		#region Methods: Public

		/// <summary>
		/// Lemmatize text.
		/// </summary>
		/// <param name="text">Input text.</param>
		/// <returns>Lemmatization input text.</returns>
		public override string Process(string text) {
			var sb = new StringBuilder();
			var lemmatizer = Lemmatizator.GetInstance();
			var content = ExecuteAnotherTextProcessing(text).ToLower();
			foreach (var word in content.Split(' ', StringSplitOptions.RemoveEmptyEntries)) {
				sb.Append(lemmatizer.Lemmatize(word)).Append(" ");
			}
			return sb.ToString().TrimEnd();
		}

		#endregion

	}

	#endregion

}
