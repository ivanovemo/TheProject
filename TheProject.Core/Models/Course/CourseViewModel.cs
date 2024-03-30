using static TheProject.Infrastructure.Constants.Constants;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TheProject.Infrastructure.Data.Models;
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
        public string Instructor { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.Required)]
        public string InstructorPhoto { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.Required)]
        public string StartDate { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.Required)]
        public string EndDate { get; set; } = string.Empty;

        public int Interested { get; set; }

        public string? Category { get; set; }

        //public IList<Lecture> Lectures { get; set; } = new List<Lecture>();
        //public IList<Review> Reviews { get; set; } = new List<Review>();
        //public IList<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
    }
}
