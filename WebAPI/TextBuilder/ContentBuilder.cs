namespace WebAPI.TextBuilder
{
	using System;
	using System.Text.RegularExpressions;

	public class ContentBuilder: TextBuilder
    {
		private string _pattern = @"[^\w\s]";
		

		public ContentBuilder(string content) {
			Text = content;
		}

		public ContentBuilder ClearMarks(string pattern = null) {
			try {
				Text = Regex.Replace(Text, pattern ?? _pattern, "");

			} catch (Exception exp) {

			}
			return this;
		}

		public new ContentBuilder Lemmatize() {
			Text = base.Lemmatize();
			return this;
		}
		public override string GetText() {
			return Text;
		}
	}
}
