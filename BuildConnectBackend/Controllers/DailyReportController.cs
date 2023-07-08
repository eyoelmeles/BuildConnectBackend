using BuildConnectBackend.Context;
using BuildConnectBackend.DTO;
using BuildConnectBackend.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace BuildConnectBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DailyReportController : ControllerBase
    {
        private readonly BuildConnectContext _context;
        private readonly ILogger<DailyReportController> _logger;
        public DailyReportController(BuildConnectContext context, ILogger<DailyReportController> logger)
        {
            _context = context;
            _logger = logger;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DailyReportDTO>>> Get()
        {

            List<DailyReport> daily_reports = await _context.DailyReports.ToListAsync();
            return Ok(daily_reports);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<DailyReport>> CreateDailyReport(CreateDailyReportDTO daily_report)
        {
            
            var userId = HttpContext.User.Claims.FirstOrDefault((claim) => claim.Type == "Id");
            if (userId == null)
            {
                return Unauthorized(new { message = "Not Authorized" });
            }
            if (daily_report.SiteId == null)
            {
                return BadRequest(new { message = "Bad Request" });
            }
            bool existingReport = await _context.DailyReports.AnyAsync(r => r.SiteId == daily_report.SiteId && r.Date.Date == DateTime.UtcNow.Date);
            if (existingReport)
            {
                return Conflict(new { message = "A DailyReport already exists for the specified SiteId and current date." });
            }
            DailyReport new_daily_report = new DailyReport()
            {
                SiteId = daily_report.SiteId,
                Date = DateTime.UtcNow,
                UserId = new Guid(userId.Value),
            };
            await _context.DailyReports.AddAsync(new_daily_report);
            await _context.SaveChangesAsync();
            return Ok("Created");
        }
    }
}
