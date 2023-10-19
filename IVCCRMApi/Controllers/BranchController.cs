using IVCCRMApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IVCCRMApi.Controllers
{
    [ApiController]
    [Route("Branch")]
    public class BranchContoller : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public ActionResult All()
        {
            IVCContext db = new IVCContext();
            return Ok(db.Branches);
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult Get(int id)
        {
            IVCContext db = new IVCContext();
            Branch? branch = db.Branches.FirstOrDefault(c => c.Id == id);
            if (branch == null)
                return NotFound();
            return Ok();
        }
        [HttpPost]
        public ActionResult Add(Branch branch)
        {
            IVCContext db = new IVCContext();
            db.Branches.Add(branch);
            db.SaveChanges();
            return Ok(branch);
        }
        [HttpDelete]

        public ActionResult Delete(int id)
        {
            IVCContext db = new IVCContext();
            Branch? branch = db.Branches.FirstOrDefault(c => c.Id == id);
            if (branch == null) return NotFound();
            db.Branches.Remove(branch);
            db.SaveChanges();
            return Ok();
        }
    }
}
