using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ReviewConstants = TheProject.Infrastructure.Constants.Constants.ReviewConstants;

namespace TheProject.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Range(ReviewConstants.MinRating, ReviewConstants.MaxRating)]
        public double Rating { get; set; }

        [Required]
        [MaxLength(ReviewConstants.DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Required]
        public int CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; } = null!;
    }
}
