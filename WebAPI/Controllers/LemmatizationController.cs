namespace WebAPI.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using WebAPI.TextBuilder;

	[Route("api/[controller]")]
    [ApiController]
    public class LemmatizationController : ControllerBase
    {
		// POST api/lemmatization
		[HttpPost]
		public ActionResult<string> Post([FromBody] string content) {
			var builder = new ContentBuilder(content)
				.ClearMarks()
				.Lemmatize();
			return builder.GetText();
		}
	}
}