using BuildConnectBackend.Context;
using BuildConnectBackend.DTO;
using BuildConnectBackend.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuildConnectBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SiteController: ControllerBase
    {
        private readonly BuildConnectContext _context;

        public SiteController(BuildConnectContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Site>>> GetSites()
        {
            Console.WriteLine(HttpContext.User.Claims);
            List<Site> sites = await _context.Sites.ToListAsync();
            return Ok(sites);
        }
        [HttpPost]
        //[Authorize]
        public async Task<ActionResult<Site>> CreateSite(CreateSiteDTO site)
        {
            Site newSite = new Site()
            {
                Name = site.Name,
                Email = site.Email,
                PhoneNumber = site.PhoneNumber,

            };
            await _context.Sites.AddAsync(newSite);
            await _context.SaveChangesAsync();
            return Ok(newSite);
        }
    }
}
