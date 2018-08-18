namespace WebAPI.Common
{
	using System.Collections.Generic;

	public class JSONRequest
    {
		public List<KeyWord> Exacts {
			get; set;
		}

		public List<KeyWord> Adjustable {
			get; set;
		}

		public List<KeyWord> Additionally {
			get; set;
		}

		public string Content {
			get; set;
		}
	}
}
