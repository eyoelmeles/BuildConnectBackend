using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildConnectBackend.Model
{
    public class DailyReport : BaseModel
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Guid SiteId { get; set; }

        [ForeignKey("SiteId")]
        public Site Site { get; set; }
        
        [Required]
        public Guid UserId{ get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
