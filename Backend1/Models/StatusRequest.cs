using System.ComponentModel.DataAnnotations;

namespace Backend1.Models
{
    public class StatusRequest
    {
        [Required]
        public string Status { get; set; }
    }
}