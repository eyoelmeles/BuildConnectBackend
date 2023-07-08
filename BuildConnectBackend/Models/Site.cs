using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BuildConnectBackend.Model
{
    public class Site : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required, MaxLength(13)]
        public string PhoneNumber { get; set; }
    }
}
