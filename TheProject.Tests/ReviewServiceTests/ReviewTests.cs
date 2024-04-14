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
        private Category _category;
        private Instructor _instructor;
        private Course _course;
        private User _user;
        private Review _review;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(options);
            _sut = new ReviewService(_context);

            _category = new Category { Id = 1, Name = "Mathematics" };
            _context.Categories.Add(_category);

            _instructor = new Instructor
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Bio = "Bio of John",
                Photo = "photo.jpg"
            };
            _context.Instructors.Add(_instructor);

            _course = new Course
            {
                Id = Guid.NewGuid(),
                Title = "Calculus",
                Description = "A course on Calculus",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(30),
                CategoryId = _category.Id,
                Instructor = _instructor,
                ImageUrl = "image.jpg",
                Interested = 20
            };
            _context.Courses.Add(_course);

            _user = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "testUser",
                Email = "testuser@example.com"
            };
            _context.Users.Add(_user);

            _review = new Review
            {
                Id = Guid.NewGuid(),
                CourseId = _course.Id,
                UserId = _user.Id,
                Description = "Excellent course",
                Rating = 5,
                User = _user
            };
            _context.Reviews.Add(_review);

            _context.SaveChanges();
        }

        [Test]
        public async Task AddReviewAsync_AddsReviewSuccessfully()
        {
            var courseId = _course.Id;
            var userId = _user.Id;

            var reviewModel = new ReviewViewModel
            {
                CourseId = courseId,
                Rating = 5,
                Description = "Excellent course"
            };

            await _sut.AddReviewAsync(reviewModel, userId);

            var review = _context.Reviews.FirstOrDefault(r => r.CourseId == courseId && r.UserId == userId);
            Assert.IsNotNull(review);
            Assert.AreEqual(reviewModel.Rating, review.Rating);
            Assert.AreEqual(reviewModel.Description, review.Description);
            Assert.AreEqual(reviewModel.CourseId, review.CourseId);
            Assert.AreEqual(userId, review.UserId);
        }

        [Test]
        public void AddReviewAsync_ThrowsForInvalidUserId()
        {
            var reviewModel = new ReviewViewModel
            {
                CourseId = _course.Id,
                Rating = 5,
                Description = "Excellent course!"
            };
            var invalidUserId = "nonexistent-user-id";

            var exception = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _sut.AddReviewAsync(reviewModel, invalidUserId));

            Assert.AreEqual("Invalid user ID.", exception.Message);
        }

        [Test]
        public void AddReviewAsync_ThrowsForInvalidCourseId()
        {
            var reviewModel = new ReviewViewModel
            {
                CourseId = Guid.NewGuid(),
                Description = "Excellent course!"
            };
            var validUserId = _user.Id;

            var exception = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _sut.AddReviewAsync(reviewModel, validUserId));

            Assert.AreEqual("Invalid course ID.", exception.Message);
        }

        [Test]
        [TestCase(0)]
        [TestCase(11)]
        public void AddReviewAsync_ThrowsForInvalidRating(int invalidRating)
        {
            var reviewModel = new ReviewViewModel
            {
                CourseId = _course.Id,
                Rating = invalidRating,
                Description = "Out of range rating"
            };

            var exception = Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () =>
                await _sut.AddReviewAsync(reviewModel, _user.Id));

            Assert.IsTrue(exception.Message.Contains("Rating must be between 1 and 10."));
        }

        [Test]
        public async Task GetReviewsByCourseIdAsync_ReturnsCorrectReviews()
        {
            var courseId = _course.Id;

            var result = await _sut.GetReviewsByCourseIdAsync(courseId);
            Assert.IsNotEmpty(result);

            var review = result.First();
            Assert.AreEqual(_review.Rating, review.Rating);
            Assert.AreEqual(_review.Description, review.Description);
            Assert.AreEqual(_user.UserName, review.Username);
        }

        [Test]
        public void GetReviewsByCourseIdAsync_ThrowsForInvalidCourseId()
        {
            var invalidCourseId = Guid.NewGuid();

            var exception = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _sut.GetReviewsByCourseIdAsync(invalidCourseId));

            Assert.AreEqual("Invalid course ID.", exception.Message);
        }
    }
}