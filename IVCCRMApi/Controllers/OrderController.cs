using IVCCRMApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IVCCRMApi.Controllers
{
    [ApiController]
    [Route("order")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IActionResult All()
        {
            IVCContext db = new IVCContext();
            return Ok(db.Orders);
        }
        [HttpPost]
        public IActionResult Add(Order order)
        {
            IVCContext db = new IVCContext();
            db.Orders.Add(order);
            db.SaveChanges();
            return Ok(order);
        }
    }
}
