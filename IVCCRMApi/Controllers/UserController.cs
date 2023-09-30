using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace IVCCRMApi.Controllers
{
	[Controller]
	[Route("user")]
	public class UserController
	{
		[HttpGet]
		public ActionResult Get(int id)
		{
			IVCContext db = new IVCContext();
			return new Ok();
		}
	}
}
