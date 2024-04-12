using Microsoft.EntityFrameworkCore;
using TheProject.Core.Contracts;
using TheProject.Core.Models.Review;
using TheProject.Core.Services;
using TheProject.Infrastructure.Data;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Tests.ReviewServiceTests
{
    [TestFixture]
    public class ReviewTests
    {
        private ApplicationDbContext _context;
        private IReviewService _sut;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(options);
            _sut = new ReviewService(_context);
        }

        [Test]
        public async Task AddReviewAsync_AddsReviewSuccessfully()
        {
            var reviewModel = new ReviewViewModel
            {
                CourseId = Guid.NewGuid(),
                Rating = 5,
                Description = "Great course!",
            };
            var userId = Guid.NewGuid().ToString();

            await _sut.AddReviewAsync(reviewModel, userId);

            var review = _context.Reviews.FirstOrDefault();
            Assert.IsNotNull(review);
            Assert.AreEqual(reviewModel.Rating, review.Rating);
            Assert.AreEqual(reviewModel.Description, review.Description);
            Assert.AreEqual(reviewModel.CourseId, review.CourseId);
            Assert.AreEqual(userId, review.UserId);
        }

        [Test]
        public async Task GetReviewsByCourseIdAsync_ReturnsCorrectReviews()
        {
            var courseId = Guid.NewGuid();
            var userId = Guid.NewGuid().ToString();
            var user = new User { Id = userId, UserName = "testuser", Email = "testuser@gmail.com" };
            _context.Users.Add(user);

            await _context.Reviews.AddAsync(new Review
            {
                Id = Guid.NewGuid(),
                CourseId = courseId,
                Rating = 5,
                Description = "Test Review",
                UserId = userId,
                User = user
            });
            await _context.SaveChangesAsync();

            var result = await _sut.GetReviewsByCourseIdAsync(courseId);
            Assert.IsNotEmpty(result);

            var review = result.First();
            Assert.AreEqual(5, review.Rating);
            Assert.AreEqual("Test Review", review.Description);
            Assert.AreEqual(user.UserName, review.Username);
        }
    }
}