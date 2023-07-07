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
        public DailyReportController(BuildConnectContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DailyReportDTO>>> Get()
        {

        List<DailyReport> daily_reports = await _context.DailyReports.ToListAsync();
            return Ok(new DailyReportDTO()
            {
                id = daily_reports.id,
                date= daily_reports.date,
                site_id = daily_reports.
                user_id = daily_reports.
            });
        }
    }
}
