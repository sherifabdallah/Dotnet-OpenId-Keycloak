using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace oidcDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, world!");
        }
        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            // Sign out the user
            await HttpContext.SignOutAsync();

            return Ok("Logged out successfully");
        }
    }
}