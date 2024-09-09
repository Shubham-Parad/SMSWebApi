using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSWebApi.Models;
using SMSWebApi.Repo;

namespace SMSWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthRepo repo;
        public AuthController(AuthRepo repo)
        {
            this.repo = repo;
        }

        [Route("SignUp")]
        [HttpPost]
        public IActionResult SignUp(Users u)
        {
            repo.SignUp(u);
            return Ok("User Registered Successfully");
        }

        [Route("SignIn")]
        [HttpPost]
        public IActionResult SignIn(Users u)
        {
            bool isAuthenticated = repo.SignIn(u);
            return Ok("User signed in successfully");
        }

    }
}
