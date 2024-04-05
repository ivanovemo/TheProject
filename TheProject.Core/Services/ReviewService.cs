using TheProject.Core.Contracts;
using TheProject.Core.Models.Review;
using TheProject.Infrastructure.Data;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Core.Services
{
    public class ReviewService : IReviewService
    {
        private readonly ApplicationDbContext _context;

        public ReviewService(ApplicationDbContext context)
        {
                _context = context;
        }

        public async Task AddReviewAsync(ReviewViewModel model, string userId)
        {
            var review = new Review()
            {
                Id = Guid.NewGuid(),
                Rating = model.Rating,
                Description = model.Description,
                CourseId = model.CourseId,
                UserId = userId
            };

            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
        }
    }
}
