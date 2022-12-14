using System.ComponentModel.DataAnnotations;

namespace Backend1.Models.Entities
{
    public class StatusEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Status { get; set; } = null!;

        public ICollection<IssueEntity> Issues { get; set; }
    }
}