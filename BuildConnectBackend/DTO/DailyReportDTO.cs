using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BuildConnectBackend.DTO
{
    public record CreateDailyReport(string site_id);
    public class DailyReportDTO
    {
        public string id { get; set; }
        public DateTime date { get; set; }
        public Guid site_id { get; set; }
        public Guid user_id{ get; set; }
    }
}