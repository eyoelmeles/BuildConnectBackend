using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations;

namespace BuildConnectBackend.Model
{
    public class User : BaseModel
    {
        [Required, MinLength(2), MaxLength(50)]
        public string user_name { get; set; }

        [Required, MinLength(8), MaxLength(13)]
        public string phone_number { get; set; }

        [Required, MinLength(2), MaxLength(512)]
        public string password { get; set; }

        [MaxLength(2048)]
        public string image_url { get; set; }
    }
}