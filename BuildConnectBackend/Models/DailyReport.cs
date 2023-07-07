using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildConnectBackend.Model
{
    public class DailyReport : BaseModel
    {
        [Required]
        public DateTime date { get; set; }

        [Required]
        public Guid site_id { get; set; }

        [ForeignKey("site_id")]
        public Site site { get; set; }
        
        [Required]
        public Guid user_id { get; set; }

        [ForeignKey("user_id")]
        public User user { get; set; }
    }
}
