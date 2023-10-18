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
        [HttpDelete]

        public ActionResult Delete(int id)
        {
            IVCContext db = new IVCContext();
            Employee? emp = db.Employees.FirstOrDefault(u => u.Id == id);
            if (emp == null) return NotFound();
            db.Employees.Remove(emp);
            db.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            IVCContext db = new IVCContext();
            db.Employees.Add(employee);
            db.SaveChanges();
            return Ok(employee);
        }
    }
}