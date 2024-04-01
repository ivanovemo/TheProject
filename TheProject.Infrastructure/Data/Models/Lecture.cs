using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LectureConstants = TheProject.Infrastructure.Constants.Constants.LectureConstants;

namespace TheProject.Infrastructure.Data.Models
{
    public class Lecture
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(LectureConstants.TitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(LectureConstants.DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }  

        [Required]
        public Guid CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; } = null!;
    }
}