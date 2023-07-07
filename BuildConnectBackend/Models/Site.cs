using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BuildConnectBackend.Model
{
    public class Site : BaseModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
        [Required, MaxLength(13)]
        public string phone_number { get; set; }
    }
}
