namespace WebAPI.TextProcessing
{

	#region Clsss ClearNewLines

	public class ClearNewLines : ReplacementTextProcessing
	{

		#region Constructors: Public

		public ClearNewLines() : base(@"\s{1,}", " ") { }

		public ClearNewLines(string pattern, string replacingPattern) : base(pattern, replacingPattern) { }

		#endregion

	}

	#endregion

}
