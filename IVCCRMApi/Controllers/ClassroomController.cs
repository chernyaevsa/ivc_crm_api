using IVCCRMApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IVCCRMApi.Controllers
{
 
    

 
    [ApiController]
    [Route("classroom")]
    public class ClassroomContoller : ControllerBase
    {

        [HttpGet]
        [Route("all")]
        public IActionResult All()
        {
            IVCContext db = new IVCContext();
            return Ok(db.Classrooms);
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            IVCContext db = new IVCContext();
            Classroom? classroom = db.Classrooms.FirstOrDefault(e => e.Id == id);
            if (classroom == null)
                return NotFound();
            db.Classrooms.Remove(classroom);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Get(int id)
        {
            IVCContext db = new IVCContext();
            Classroom? classroom = db.Classrooms.FirstOrDefault(e => e.Id == id);
            if (classroom == null)
                return NotFound();
            return Ok(classroom);
        }
        [HttpPost]   
        public ActionResult Add(Classroom classroom)
        {
            IVCContext db = new IVCContext();
            db.Classrooms.Add(classroom);
            db.SaveChanges();
            return Ok(classroom);
        }

    }
}
