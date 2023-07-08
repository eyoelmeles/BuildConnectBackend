using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BuildConnectBackend.DTO
{
    public record CreateDailyReportDTO(Guid SiteId);
    public record CreateSiteDTO(string Email, string Name, string PhoneNumber);
    public class DailyReportDTO
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid SiteId { get; set; }
        public Guid UserId{ get; set; }
    }
}