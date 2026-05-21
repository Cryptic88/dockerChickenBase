using Microsoft.AspNetCore.Mvc;

namespace ChickenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EggController : Controller
    {
        [HttpGet("/GetMeEggs")]
        public ActionResult<string> GetMeEggs()
        {
            return Ok("Here are the eggs!");
        }
    }
}