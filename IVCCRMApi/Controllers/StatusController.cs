using IVCCRMApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IVCCRMApi.Controllers
{
    [ApiController]
    [Route("equipmentStatus")]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IActionResult All()
        {
            IVCContext db = new IVCContext();
            return Ok(db.EquipmentStatuses);
        }

        [HttpPost]
        public IActionResult Add(EquipmentStatus equipmentStatus)
        {
            IVCContext db = new IVCContext();
            db.EquipmentStatuses.Add(equipmentStatus);
            db.SaveChanges();
            return Ok(equipmentStatus);
        }

    }
}
