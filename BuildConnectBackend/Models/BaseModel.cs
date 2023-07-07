using System.ComponentModel.DataAnnotations;

namespace BuildConnectBackend.Model
{
    public abstract class BaseModel
    {
        [Key]
        public Guid id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime update_at { get; set; }
    }
}