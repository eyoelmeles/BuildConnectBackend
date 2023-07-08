using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BuildConnectBackend.DTO
{
    public record CreateDailyReport(string SiteId, string UserId);
    public class DailyReportDTO
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid SiteId { get; set; }
        public Guid UserId{ get; set; }
    }
}