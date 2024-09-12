using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSWebApi.Models;
using SMSWebApi.Repo;

namespace SMSWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentRepo repo;
        public StudentController(StudentRepo repo)
        {
            this.repo = repo;
        }

        [Route("AddStudent/")]
        [HttpPost]
        public IActionResult AddStudent(Student s)
        {
            repo.AddStudent(s);
            return Ok("Student added successfully!!!");
        }
    }
}
