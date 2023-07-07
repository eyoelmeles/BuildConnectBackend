using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildConnectBackend.Model
{
    public class WorkHour : BaseModel
    {
        [Required, MinLength(2), MaxLength(50)]
        public int work_hour { get; set; }
        public Guid daily_report_id { get; set; }
        [ForeignKey("daily_report_id")]
        public DailyReport daily_report { get; set; }
    }
}

