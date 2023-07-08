using BuildConnectBackend.Context;
using BuildConnectBackend.DTO;
using BuildConnectBackend.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}
