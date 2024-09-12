using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSWebApi.Models;
using SMSWebApi.Repo;

namespace SMSWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
        private readonly ParentRepo repo;
        public ParentController(ParentRepo repo)
        {
            this.repo = repo;
        }
        [Route("AddParent/")]
        [HttpPost]
        public IActionResult AddParent(Parent p)
        {
            repo.AddParent(p);
            return Ok("Parent added successfully!!!");
        }
    }
}
