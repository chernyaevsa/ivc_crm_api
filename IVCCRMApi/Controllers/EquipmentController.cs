using IVCCRMApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IVCCRMApi.Controllers
{
    [ApiController]
    [Route("equipment")]
    public class EquipmentController : ControllerBase
    {
        [HttpPost]
        public ActionResult Add(Equipment equipment)
        {
            IVCContext db = new IVCContext();
            db.Equipments.Add(equipment);
            db.SaveChanges();
            return Ok(equipment);
        }

        [HttpGet]
        [Route("all")]
        public ActionResult All()
        {
            IVCContext db = new IVCContext();
            return Ok(db.Equipments);
        }
    }
}
