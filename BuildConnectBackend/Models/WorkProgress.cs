using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesApi.Model
{
    public class WorkProgress : BaseModel
    {
        [Required]
        public string TypeOfWork{ get; set; } = string.Empty;
        [Required]
        public string Location { get; set; } = string.Empty;
        [Required]
        public string Unit { get; set; } = string.Empty;
        [Required]
        public string Quantity { get; set; } = string.Empty;
        [Required]
        public string Remark { get; set; } = string.Empty;
        public Guid DailyReportId { get; set; }
        [ForeignKey("DailyReportId")]
        public DailyReport DailyReport { get; set; }
    }
}


