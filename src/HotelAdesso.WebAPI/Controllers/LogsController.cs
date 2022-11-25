using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAdesso.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        [HttpGet("logSuccess")]
        public IActionResult LogSuccessTest()
        {
            return Ok();
        }
        [HttpGet("logError")]
        public IActionResult LogErrorTest()
        {
            return BadRequest();
        }
    }
}
