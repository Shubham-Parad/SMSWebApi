using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSWebApi.Models;
using SMSWebApi.Repo;

namespace SMSWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly TeacherRepo repo;
        public TeacherController(TeacherRepo repo)
        {
            this.repo = repo;
        }
        [Route("AddTeacher/")]
        [HttpPost]
        public IActionResult AddTeacher(Teacher t)
        {
            repo.AddTeacher(t);
            return Ok("Teacher added successfully!!!");
        }
    }
}
