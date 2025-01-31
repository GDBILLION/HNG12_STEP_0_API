using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNG12API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HNGController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDetails()
        {
            var response = new
            {
                email = "godwindpius@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                github_url = "https://github.com/GDBILLION/HNG12_STEP_0_API.git"
            };

            return Ok(response);
        }
    }
}
