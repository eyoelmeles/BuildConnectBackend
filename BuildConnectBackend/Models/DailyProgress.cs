using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesApi.Model
{
    public class WorkProgress : BaseModel
    {
        [Required]
        public string type_of_material{ get; set; }
        [Required]
        public string location { get; set; }
        [Required]
        public string unit { get; set; }
        [Required]
        public string quantity { get; set; }
        [Required]
        public string remark { get; set; } = string.Empty;
        public Guid daily_report_id { get; set; }
        [ForeignKey("daily_report_id")]
        public DailyReport daily_report { get; set; }
    }
}


