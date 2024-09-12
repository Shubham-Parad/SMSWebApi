using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSWebApi.Models;
using SMSWebApi.Repo;

namespace SMSWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimetableController : ControllerBase
    {
        private readonly TimetableRepo repo;
        public TimetableController(TimetableRepo repo)
        {
            this.repo = repo;
        }

        [Route("AddTimetable/")]
        [HttpPost]
        public IActionResult AddTimetable(Timetable t)
        {
            repo.AddTimetable(t);
            return Ok("Timetable added successfully!!!");
        }
    }
}
