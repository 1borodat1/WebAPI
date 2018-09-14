namespace WebAPI.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using WebAPI.TextProcessing;

	[Route("api/[controller]")]
    [ApiController]
    public class WordsLemmatizerController : ControllerBase
    {
		// POST api/lemmatization
		[HttpPost]
		public ActionResult<string> Post([FromBody] string content) {
			var wordsLemmatizator = new WordsLemmatizer();
			wordsLemmatizator.AddTextProcessing(new ClearNewLines());
			wordsLemmatizator.AddTextProcessing(new ClearTextPunctuator());
			return wordsLemmatizator.Process(content);
		}
	}
}