using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InstructorConstants = TheProject.Infrastructure.Constants.Constants.InstructorConstants;

namespace TheProject.Infrastructure.Data.Models
{
    public class Instructor
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(InstructorConstants.FirstNameMaxLength)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(InstructorConstants.LastNameMaxLength)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [MaxLength(InstructorConstants.BioxMaxLength)]
        public string Bio { get; set; } = string.Empty;

        [Required]
        public string Photo { get; set; } = string.Empty;

        [Required]
        public Guid CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; } = null!;
    }
}
