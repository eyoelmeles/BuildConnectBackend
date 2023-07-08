using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildConnectBackend.Model
{
    public class Weather : BaseModel
    {
        [Required, MinLength(2), MaxLength(50)]
        public WeatherType WeatherCondition { get; set; } = WeatherType.Sunny;
        public Guid DailyReportId { get; set; }
        [ForeignKey("DailyReportId")]
        public DailyReport DailyReport{ get; set; }
    }
}
