using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet("hello")]
        [Authorize]
        public IActionResult GetHello()
        {
            return Ok("Hello from protected API!");
        }
    }
}