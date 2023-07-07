using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildConnectBackend.Model
{
    public class MaterialReport : BaseModel
    {
        [Required]
        public string type_of_material { get; set; }
        [Required]
        public string location { get; set; }
        [Required]
        public string unit { get; set; }
        [Required]
        public string delivered { get; set; }
        [Required]
        public string remark { get; set; } = string.Empty;
        [Required]
        public DateTime to_date { get; set; }
        public Guid daily_report_id { get; set; }
        [ForeignKey("daily_report_id")]
        public DailyReport daily_report { get; set; }
    }
}

