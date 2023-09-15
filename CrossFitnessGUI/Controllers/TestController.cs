using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        [HttpGet("Test1")]
        public IActionResult Pippo()
        {
            return Ok("TEST1API");
        }

        [HttpGet("Test2")]
        public IActionResult GET2()
        {
            return Ok("TEST2API");
        }
    }
}