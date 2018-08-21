namespace WebAPI.TextBuilder
{
	using System.Text;

	public abstract class TextBuilder
    {
		protected string Text;
		public abstract string GetText();

		protected virtual string Lemmatize() {
			var sb = new StringBuilder();
			var lemmatizer = Lemmatizator.GetInstance();
			foreach (var word in Text.ToLower().Split(' ')) {
				sb.Append(lemmatizer.Lemmatize(word)).Append(" ");
			}
			return sb.ToString();
		}
	}
}
