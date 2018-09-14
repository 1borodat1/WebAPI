using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WebAPI.Data;

namespace WebAPI.TextProcessing
{
    public class WordsLemmatizer: BaseTextProcessing
	{

		#region Methods: Public

		/// <summary>
		/// Lemmatize text.
		/// </summary>
		/// <param name="text">Input text.</param>
		/// <returns>Json string with lemma and input word.</returns>
		public override string Process(string text) {
			var wordBoxes = new List<WordBox>();
			var lemmatizer = Lemmatizator.GetInstance();
			var content = ExecuteAnotherTextProcessing(text).ToLower();
			foreach (var word in content.Split(' ', StringSplitOptions.RemoveEmptyEntries)) {
				wordBoxes.Add(new WordBox() {
					L = lemmatizer.Lemmatize(word),
					W = word
				});
				lemmatizer.Lemmatize(word);
			}
			return JsonConvert.SerializeObject(wordBoxes);
		}

		#endregion

	}
}
