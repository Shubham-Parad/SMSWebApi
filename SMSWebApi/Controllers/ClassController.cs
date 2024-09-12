using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSWebApi.Models;
using SMSWebApi.Repo;

namespace SMSWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly ClassRepo repo;
        public ClassController(ClassRepo repo)
        {
            this.repo = repo;
        }

        [Route("AddClass/")]
        [HttpPost]
        public IActionResult AddClass(Classes c)
        {
            repo.AddClass(c);
            return Ok("Class Added Successfully!!");
        }
    }
}
