using IVCCRMApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IVCCRMApi.Controllers
{
    [ApiController]
    [Route("order")]
    public class OrderController : ControllerBase
    {
        public ActionResult Get(int id)
        {
            IVCContext db = new IVCContext();
            Order?order = db.Orders.FirstOrDefault(e => e.Id == id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            IVCContext db = new IVCContext();
            Order? order= db.Orders.FirstOrDefault(e => e.Id == id);
            if (order == null)
                return NotFound();
            db.Orders.Remove(order);
            db.SaveChanges();
            return Ok();
        }

    
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
