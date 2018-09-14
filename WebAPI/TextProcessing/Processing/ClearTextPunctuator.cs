namespace WebAPI.TextProcessing
{

	#region Class ClearTextPunctuator 

	public class ClearTextPunctuator : ReplacementTextProcessing
	{

		#region Constructor: Public

		public ClearTextPunctuator() : base(@"[^\w\s]", string.Empty) { }

		public ClearTextPunctuator(string pattern, string replacingPattern) : base(pattern, replacingPattern) {
		}

		#endregion

	}

	#endregion

}
