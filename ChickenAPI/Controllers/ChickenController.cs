using Microsoft.AspNetCore.Mvc;

namespace ChickenAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChickenController : ControllerBase
    {
        private static readonly List<object> Chickens = new();

        [HttpGet("api/chicken")]
        [HttpGet("/api/chicken")]
        public IActionResult GetAll()
        {
            return Ok(Chickens);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ChickenRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Name) || string.IsNullOrWhiteSpace(request.Breed))
            {
                return BadRequest("Both name and breed are required.");
            }

            var chicken = new
            {
                request.Name,
                request.Breed
            };

            Chickens.Add(chicken);

            return Ok(chicken);
        }
    }

    public sealed record ChickenRequest(string Name, string Breed);
}