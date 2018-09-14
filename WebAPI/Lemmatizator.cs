namespace WebAPI
{
	using LemmaSharp.Classes;
	using System.IO;

	#region Class: Lemmatizator

	public sealed class Lemmatizator
	{
		private static readonly Lemmatizer _lemmatizer;
		static Lemmatizator() {
			var stream = new FileStream(@"wwwroot/full7z-mlteast-ru.lem", FileMode.Open);
			using (stream) {
				_lemmatizer = new Lemmatizer(stream);
			}
		}

		private Lemmatizator() {
		}

		public static Lemmatizer GetInstance() {
			return _lemmatizer;
		}
	}

	#endregion

}
