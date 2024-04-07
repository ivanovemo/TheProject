using Microsoft.EntityFrameworkCore;
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

            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<ReviewViewModel>> GetReviewsByCourseIdAsync(Guid courseId)
        {
            return await _context.Reviews
                             .Where(r => r.CourseId == courseId)
                             .Select(r => new ReviewViewModel
                             {
                                 Id = r.Id,
                                 Rating = r.Rating,
                                 Description = r.Description,
                                 CourseId = r.CourseId,
                                 Username = r.User.UserName
                             })
                             .ToListAsync();
        }
    }
}
