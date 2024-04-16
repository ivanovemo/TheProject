using static TheProject.Infrastructure.Constants.Constants;
using System.ComponentModel.DataAnnotations;

namespace TheProject.Core.Models.Lecture
{
    public class LectureViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = ErrorMessages.Required)]
        [StringLength(LectureConstants.TitleMaxLength,
            MinimumLength = LectureConstants.TitleMinLength,
            ErrorMessage = ErrorMessages.Length)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.Required)]
        [StringLength(LectureConstants.DescriptionMaxLength,
            MinimumLength = LectureConstants.DescriptionMinLength,
            ErrorMessage = ErrorMessages.Length)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}$",
            ErrorMessage = ErrorMessages.LectureDateFormat)]
        public string StartDate { get; set; } = string.Empty;
        public Guid CourseId { get; set; }

        [Required(ErrorMessage = ErrorMessages.Required)]
        [Range(LectureConstants.MinDurationValue, LectureConstants.MaxDurationValue,
            ErrorMessage = ErrorMessages.Range)]
        public int Duration { get; set; }
    }
}
