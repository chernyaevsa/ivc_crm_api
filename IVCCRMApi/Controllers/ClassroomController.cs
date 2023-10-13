using IVCCRMApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IVCCRMApi.Controllers
{
    [ApiController]
    [Route("classroom")]
    public class ClassroomContoller : ControllerBase
    {

        [HttpGet]
        public IActionResult GetList()
        {
            IVCContext db = new IVCContext();
            return Ok(db.Classrooms);
        }
    }
}
