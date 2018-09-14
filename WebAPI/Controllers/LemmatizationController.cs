namespace WebAPI.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using WebAPI.TextProcessing;

	[Route("api/[controller]")]
    [ApiController]
    public class LemmatizationController : ControllerBase
    {
		// POST api/lemmatization
		[HttpPost]
		public ActionResult<string> Post([FromBody] string content) {
			var textLemmatizator = new TextLemmatizer();
			textLemmatizator.AddTextProcessing(new ClearNewLines());
			textLemmatizator.AddTextProcessing(new ClearTextPunctuator());
			return textLemmatizator.Process(content);
		}

	}
}