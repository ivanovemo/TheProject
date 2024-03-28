using System.ComponentModel.DataAnnotations;
using CategoryConstants = TheProject.Infrastructure.Constants.Constants.CategoryConstants;

namespace TheProject.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(CategoryConstants.NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        public IList<Course> Courses { get; set; } = new List<Course>();
    }
}
