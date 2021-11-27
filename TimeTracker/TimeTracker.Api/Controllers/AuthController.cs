using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TimeTracker.Services.Interfaces.Services.Utils;
using TimeTracker.Services.Models.User;

namespace TimeTracker.Api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(UserLogin userLogin)
        {
            var authData = await authService.LoginAsync(userLogin);
            if (authData != null)
            {
                return Ok(authData);
            }
            else
            {
                return BadRequest();
            }
        }

        [Authorize]
        [HttpGet]
        [Route("test")]
        public IActionResult Test()
        {
            return Ok("test");
        }
    }
}
