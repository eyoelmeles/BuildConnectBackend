using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations;

namespace BuildConnectBackend.Model
{
    public class User : BaseModel
    {
        [Required, MinLength(2), MaxLength(50)]
        public string UserName { get; set; } = string.Empty;

        [Required, MinLength(8), MaxLength(13)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required, MinLength(2), MaxLength(512)]
        public string Password { get; set; } = string.Empty;

        [MaxLength(2048)]
        public string ImageURL { get; set; } = string.Empty;
    }
}