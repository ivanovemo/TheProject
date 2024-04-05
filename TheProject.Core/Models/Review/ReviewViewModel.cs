using static TheProject.Infrastructure.Constants.Constants;
using System.ComponentModel.DataAnnotations;

namespace TheProject.Core.Models.Review
{
    public class ReviewViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = ErrorMessages.Required)]
        [Range(ReviewConstants.MinRating, ReviewConstants.MaxRating)]
        public int Rating { get; set; }

        [Required(ErrorMessage = ErrorMessages.Required)]
        [StringLength(ReviewConstants.DescriptionMaxLength,
            MinimumLength = ReviewConstants.DescriptionMinLength,
            ErrorMessage = ErrorMessages.Length)]
        public string Description { get; set; } = string.Empty;
    }
}
