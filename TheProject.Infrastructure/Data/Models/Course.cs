using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CourseConstants = TheProject.Infrastructure.Constants.Constants.CourseConstants;

namespace TheProject.Infrastructure.Data.Models
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(CourseConstants.TitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(CourseConstants.DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public Instructor Instructor { get; set; } = null!;

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public int Interested { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public IList<Lecture> Lectures { get; set; } = new List<Lecture>();
        public IList<Review> Reviews { get; set; } = new List<Review>();
        public IList<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
    }
}
