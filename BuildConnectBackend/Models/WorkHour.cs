using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildConnectBackend.Model
{
    public class WorkHour : BaseModel
    {
        [Required, MinLength(2), MaxLength(50)]
        public int WorkHr { get; set; }
        public Guid DailyReportId { get; set; }
        [ForeignKey("DailyReportId")]
        public DailyReport DailyReport{ get; set; }
    }
}

