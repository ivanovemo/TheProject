using static TheProject.Infrastructure.Constants.Constants;
using System.ComponentModel.DataAnnotations;

namespace TheProject.Core.Models.Course
{
    public class InstructorViewModel
    {
        [Required(ErrorMessage = ErrorMessages.Required)]
        [StringLength(InstructorConstants.FirstNameMaxLength,
            MinimumLength = InstructorConstants.FirstNameMinLength,
            ErrorMessage = ErrorMessages.Length)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.Required)]
        [StringLength(InstructorConstants.LastNameMaxLength,
            MinimumLength = InstructorConstants.LastNameMinLength,
            ErrorMessage = ErrorMessages.Length)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.Required)]
        [StringLength(InstructorConstants.BioxMaxLength,
            MinimumLength = InstructorConstants.BioMinLength,
            ErrorMessage = ErrorMessages.Length)]
        public string Bio { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.Required)]
        public string Photo { get; set; } = string.Empty;
    }
}
