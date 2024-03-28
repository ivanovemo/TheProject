using System.ComponentModel.DataAnnotations;

namespace TheProject.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        public IList<Course> Courses { get; set; } = new List<Course>();
    }
}
