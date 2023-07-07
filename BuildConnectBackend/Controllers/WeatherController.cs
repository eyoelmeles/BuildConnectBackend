using BuildConnectBackend.Context;
using BuildConnectBackend.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipesApi.Model;

namespace BuildConnectBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly BuildConnectContext _context;
        public WeatherController(BuildConnectContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weather>>> Get()
        {
            List<Weather> users = await _context.Weathers.ToListAsync();
            return Ok(users);
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Weather>> CreateWeather(Weather weather)
        {
            Console.WriteLine(HttpContext.User);
            return Ok(weather);
        }
    }
}
