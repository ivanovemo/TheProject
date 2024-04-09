using System.ComponentModel.DataAnnotations;
using TheProject.Core.Models.Category;
using TheProject.Core.Models.Instructor;
using TheProject.Core.Models.Lecture;
using TheProject.Core.Models.Review;
using static TheProject.Infrastructure.Constants.Constants;
using ErrorMessages = TheProject.Infrastructure.Constants.Constants.ErrorMessages;

namespace TheProject.Core.Models.Course
{
    public class CourseViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = ErrorMessages.Required)]
        [StringLength(CourseConstants.TitleMaxLength,
            MinimumLength = CourseConstants.TitleMinLength,
            ErrorMessage = ErrorMessages.Length)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.Required)]
        [StringLength(CourseConstants.DescriptionMaxLength,
            MinimumLength = CourseConstants.DescriptionMinLength,
            ErrorMessage = ErrorMessages.Length)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.Required)]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.Required)]
        [RegularExpression(@"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/(19|20)\d{2}$", ErrorMessage = ErrorMessages.DateFormat)]
        public string StartDate { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.Required)]
        [RegularExpression(@"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/(19|20)\d{2}$", ErrorMessage = ErrorMessages.DateFormat)]
        public string EndDate { get; set; } = string.Empty;

        public int Interested { get; set; }

        public int CategoryId { get; set; }
        public string Category { get; set; } = string.Empty;
        public InstructorViewModel Instructor { get; set; } = new InstructorViewModel();
        public IEnumerable<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
        public IList<ReviewViewModel> Reviews { get; set; } = new List<ReviewViewModel>();
        public IList<LectureViewModel> Lectures { get; set; } = new List<LectureViewModel>();
    }
}
