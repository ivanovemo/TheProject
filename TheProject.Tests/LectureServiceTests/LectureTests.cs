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
        private ILectureService _service;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(options);
            _service = new LectureService(_context);
        }

        [Test]
        public async Task AddLectureAsync_AddsLectureCorrectly()
        {
            var model = new LectureViewModel
            {
                Title = "New Lecture",
                Description = "This is a test lecture",
                Duration = 90,
                StartDate = "10/10/2023 14:00",
                CourseId = Guid.NewGuid()
            };
            DateTime startDate = DateTime.Parse(model.StartDate);

            await _service.AddLectureAsync(model, startDate);

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

            await _service.DeleteLectureAsync(lecture.Id);

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

            var result = await _service.GetLectureByIdAsync(lecture.Id);

            Assert.IsNotNull(result);
            Assert.AreEqual(lecture.Title, result.Title);
            Assert.AreEqual(lecture.Description, result.Description);
        }

        [Test]
        public async Task GetLecturesByCourseId_ReturnsLecturesCorrectly()
        {
            var courseId = Guid.NewGuid();
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

            var results = await _service.GetLecturesByCourseId(courseId);

            Assert.IsNotEmpty(results);
            var result = results.First();
            Assert.AreEqual(lecture.Title, result.Title);
            Assert.AreEqual(lecture.Description, result.Description);
        }
    }
}
