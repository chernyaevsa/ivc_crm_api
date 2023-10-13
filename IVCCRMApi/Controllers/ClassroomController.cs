using IVCCRMApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IVCCRMApi.Controllers
{
    [ApiController]
    [Route("classroom")]
    public class ClassroomContoller : ControllerBase
    {

        [HttpGet]
        public void GetList()
        {
            IVCContext db = new IVCContext();
            List <Branch> branches = new List<Branch> ();

            for (int i = 0; i < branches.Count; i++)
            {
                branches[i].Name.ToString();
            }
        }

        [HttpPost]
        public void Add(List<Branch> branches)
        {

        }
    }
}
