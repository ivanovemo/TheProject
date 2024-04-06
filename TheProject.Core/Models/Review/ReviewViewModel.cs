using static TheProject.Infrastructure.Constants.Constants;
using System.ComponentModel.DataAnnotations;

namespace TheProject.Core.Models.Review
{
    public class ReviewViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = ErrorMessages.Required)]
        public int Rating { get; set; }

        [Required(ErrorMessage = ErrorMessages.Required)]
        public string Description { get; set; } = string.Empty;
        public Guid CourseId { get; set; }
        public string Username { get; set; } = string.Empty;
    }
}
