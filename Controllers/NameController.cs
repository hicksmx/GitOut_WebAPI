using Microsoft.AspNetCore.Mvc;

namespace GitOut_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var response = new { name = "Max Hicks" };
            return Ok(response);
        }
    }
}
