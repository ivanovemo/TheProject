using Microsoft.EntityFrameworkCore;
using TheProject.Core.Contracts;
using TheProject.Core.Models.Lecture;
using TheProject.Core.Services;
using TheProject.Infrastructure.Data;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Tests.LectureServiceTests
{
    [TestFixture]
    public class LectureTests
    {
        private ApplicationDbContext _context;
        private ILectureService _sut;
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
            _sut = new LectureService(_context);

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
        public async Task AddLectureAsync_AddsLectureCorrectly()
        {
            var courseId = Guid.NewGuid();
            var course = new Course
            {
                Id = courseId,
                Title = "Test Course",
                Description = "A course for testing lectures",
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(30),
                CategoryId = _category.Id,
                Instructor = _instructor
            };
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();

            var model = new LectureViewModel
            {
                Title = "New Lecture",
                Description = "This is a test lecture",
                Duration = 90,
                StartDate = "10/10/2023 14:00",
                CourseId = courseId
            };
            DateTime startDate = DateTime.Parse(model.StartDate);

            await _sut.AddLectureAsync(model, startDate);

            var addedLecture = await _context.Lectures.FirstOrDefaultAsync(l => l.Title == model.Title);
            Assert.IsNotNull(addedLecture);
            Assert.AreEqual(model.Title, addedLecture.Title);
            Assert.AreEqual(model.Description, addedLecture.Description);
            Assert.AreEqual(model.Duration, addedLecture.Duration);
        }


        [Test]
        public async Task DeleteLectureAsync_DeletesLectureCorrectly()
        {
            var lecture = new Lecture
            {
                Id = Guid.NewGuid(),
                Title = "Lecture to Delete",
                Description = "Description",
                Duration = 60,
                StartDate = DateTime.Now,
                CourseId = Guid.NewGuid()
            };
            await _context.Lectures.AddAsync(lecture);
            await _context.SaveChangesAsync();

            await _sut.DeleteLectureAsync(lecture.Id);

            var deletedLecture = await _context.Lectures.FindAsync(lecture.Id);
            Assert.IsNull(deletedLecture);
        }

        [Test]
        public async Task GetLectureByIdAsync_ReturnsLectureCorrectly()
        {
            var lecture = new Lecture
            {
                Id = Guid.NewGuid(),
                Title = "Existing Lecture",
                Description = "Description",
                Duration = 60,
                StartDate = DateTime.Now,
                CourseId = Guid.NewGuid()
            };
            await _context.Lectures.AddAsync(lecture);
            await _context.SaveChangesAsync();

            var result = await _sut.GetLectureByIdAsync(lecture.Id);

            Assert.IsNotNull(result);
            Assert.AreEqual(lecture.Title, result.Title);
            Assert.AreEqual(lecture.Description, result.Description);
        }

        [Test]
        public async Task GetLecturesByCourseId_ReturnsLecturesCorrectly()
        {
            var courseId = Guid.NewGuid();
            var course = new Course
            {
                Id = courseId,
                Title = "Test Course",
                Description = "A course for testing",
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(10),
                CategoryId = _category.Id,
                Instructor = _instructor
            };
            await _context.Courses.AddAsync(course);

            var lecture = new Lecture
            {
                Id = Guid.NewGuid(),
                Title = "Course Lecture",
                Description = "Description",
                Duration = 60,
                StartDate = DateTime.Now,
                CourseId = courseId
            };
            await _context.Lectures.AddAsync(lecture);
            await _context.SaveChangesAsync();

            var results = await _sut.GetLecturesByCourseId(courseId);

            Assert.IsNotEmpty(results);
            var result = results.First();
            Assert.AreEqual(lecture.Title, result.Title);
            Assert.AreEqual(lecture.Description, result.Description);
        }

        [Test]
        public void AddLectureAsync_ThrowsWhenCourseDoesNotExist()
        {
            var model = new LectureViewModel
            {
                Title = "Lecture Without Course",
                Description = "Test Description",
                Duration = 45,
                StartDate = "01/01/2024 12:00",
                CourseId = Guid.NewGuid()
            };
            DateTime startDate = DateTime.Parse(model.StartDate);

            var ex = Assert.ThrowsAsync<ArgumentException>(() => _sut.AddLectureAsync(model, startDate));
            Assert.That(ex.Message, Is.EqualTo($"No course found with ID {model.CourseId}. Cannot add lecture."));
        }

        [Test]
        public void DeleteLectureAsync_ThrowsWhenLectureDoesNotExist()
        {
            var nonExistentLectureId = Guid.NewGuid();

            var ex = Assert.ThrowsAsync<ArgumentException>(() => _sut.DeleteLectureAsync(nonExistentLectureId));
            Assert.That(ex.Message, Is.EqualTo($"A lecture with the ID {nonExistentLectureId} was not found."));
        }

        [Test]
        public void GetLectureByIdAsync_ThrowsWhenLectureDoesNotExist()
        {
            var nonExistentLectureId = Guid.NewGuid();

            var ex = Assert.ThrowsAsync<ArgumentException>(() => _sut.GetLectureByIdAsync(nonExistentLectureId));
            Assert.That(ex.Message, Is.EqualTo($"A lecture with the ID {nonExistentLectureId} was not found."));
        }

        [Test]
        public async Task GetLecturesByCourseId_ReturnsEmptyWhenNoLecturesExist()
        {
            var courseId = Guid.NewGuid();
                                          
            var course = new Course { Id = courseId, Title = "Empty Course", Description = "No lectures here", StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(30), CategoryId = _category.Id, Instructor = _instructor };
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();

            var results = await _sut.GetLecturesByCourseId(courseId);

            Assert.IsEmpty(results);
        }

    }
}
