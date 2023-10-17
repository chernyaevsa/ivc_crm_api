using IVCCRMApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IVCCRMApi.Controllers
{
	[ApiController]
	[Route("employee")]
	public class EmployeeController : ControllerBase
	{
		[HttpGet]
		[Route("all")]
		public ActionResult All()
		{
			IVCContext db = new IVCContext();
			return Ok(db.Employees);
		}
		[HttpGet]
		public ActionResult Get(int id)
		{
			IVCContext db = new IVCContext();
			Employee? emp = db.Employees.FirstOrDefault(u => u.Id == id);
			if (emp == null) return NotFound();
			return Ok();	
		}

		[HttpDelete]
        [Route("all")]
        public ActionResult Delete(int id) 
		{
			IVCContext db = new IVCContext();
			Employee? employee = db.Employees.FirstOrDefault(e => e.Id == id);
			if (employee == null)
				return NotFound();
			db.Employees.Remove(employee);
			db.SaveChanges();
			return Ok(employee);
		}
	}
}
