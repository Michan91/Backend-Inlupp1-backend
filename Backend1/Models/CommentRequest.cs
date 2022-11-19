using System.ComponentModel.DataAnnotations;

namespace Backend1.Models
{
    public class CommentRequest
    {
        [Required]
        public string Comment { get; set; }

        [Required]
        public int IssueId { get; set; }

        [Required]
        public int CustomerId { get; set; }
    }
}