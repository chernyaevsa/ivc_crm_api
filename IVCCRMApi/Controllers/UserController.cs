using IVCCRMApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace IVCCRMApi.Controllers
{
	[ApiController]
	[Route("user")]
	public class UserController : ControllerBase
	{
		[HttpGet]
		public IActionResult Get(int id)
		{
			IVCContext db = new IVCContext();
			User? user = db.Users.FirstOrDefault(u => u.Id == id);
			if (user == null) { return NotFound(); }
			return Ok(user);
		}
		[HttpPost]
		public IActionResult Add(User user)
		{
			IVCContext db = new IVCContext();
			db.Users.Add(user);
			db.SaveChanges();
			return Ok(user);
		}
		[HttpPost]
		[Route("auth")]
		public IActionResult Auth(User? user)
		{
			IVCContext db = new IVCContext();
			user = db.Users.FirstOrDefault(u => u.Login == user.Login && u.Password == user.Password);
			if (user == null ) { return NotFound(); }
			db.SaveChanges();
			return Ok(user);
		}
		[HttpGet]
        [Route("get")]
        public IActionResult All() 
		{
            IVCContext db = new IVCContext();
            return Ok(db.Users);
        }
		

	}
}
