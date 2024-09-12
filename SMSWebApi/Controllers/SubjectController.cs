using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSWebApi.Models;
using SMSWebApi.Repo;

namespace SMSWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly SubjectRepo repo;
        public SubjectController(SubjectRepo repo)
        {
            this.repo = repo;
        }
        [Route("AddSubject/")]
        [HttpPost]
        public IActionResult AddSubject(Subject s)
        {
            repo.AddSubject(s);
            return Ok("Added subject successfully!!!");
        }
    }
}
