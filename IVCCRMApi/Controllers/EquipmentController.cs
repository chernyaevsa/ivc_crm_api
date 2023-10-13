using IVCCRMApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IVCCRMApi.Controllers
{
    [ApiController]
    [Route("equipment")]
    public class EquipmentController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public ActionResult All()
        {
            IVCContext db = new IVCContext();
            return Ok(db.Equipments);
        }
      
    }
}
