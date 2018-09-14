namespace WebAPI.TextProcessing
{
	using System;
	using System.Text.RegularExpressions;

	#region Class ReplacementTextProcessing

	public class ReplacementTextProcessing : BaseTextProcessing
	{
		#region Properties: Protected

		/// <summary>
		/// Pattern to regex replacement.
		/// </summary>
		protected virtual string Pattern {
			get; set;
		}

		/// <summary>
		/// ReplacingPattern to regex replacement.
		/// </summary>
		protected virtual string ReplacingPattern {
			get; set;
		}

		#endregion

		#region Constructor: Public

		public ReplacementTextProcessing(): base() { }

		public ReplacementTextProcessing(string pattern, string replacingPattern): base() {
			Pattern = pattern;
			ReplacingPattern = replacingPattern;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Text processing.
		/// </summary>
		/// <param name="text">Text to process.</param>
		public override string Process(string text) {
			if (string.IsNullOrEmpty(Pattern) || ReplacingPattern == null) {
				throw new ArgumentNullException($"Pattern:{Pattern}, ReplacingPattern:{ReplacingPattern}");
			}
			try {
				var textAfterAnotherProcessing = ExecuteAnotherTextProcessing(text);
				return Regex.Replace(textAfterAnotherProcessing, Pattern, ReplacingPattern);
			} catch (Exception exp) {

			}
			return null;
		}

		#endregion
	}

	#endregion

}
