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
            if (string.IsNullOrEmpty(userId) || !await _context.Users.AnyAsync(u => u.Id == userId))
            {
                throw new ArgumentException("Invalid user ID.");
            }

            if (!await _context.Courses.AnyAsync(c => c.Id == model.CourseId))
            {
                throw new ArgumentException("Invalid course ID.");
            }

            if (model.Rating < 1 || model.Rating > 10)
            {
                throw new ArgumentOutOfRangeException("Rating must be between 1 and 10.");
            }

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

        public async Task<IList<ReviewViewModel>> GetReviewsByCourseIdAsync(Guid courseId)
        {
            if (!await _context.Courses.AnyAsync(c => c.Id == courseId))
            {
                throw new ArgumentException("Invalid course ID.");
            }

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
