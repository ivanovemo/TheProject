using TheProject.Core.Contracts;
using TheProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using TheProject.Core.Services;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Tests.InstructorServiceTests
{
    [TestFixture]
    public class InstructorTests
    {
        private IInstructorService? _sut;
        private ApplicationDbContext _context;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(options);

            _context.Instructors.Add(new Instructor
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Photo = "photo.jpg",
                Bio = "A sample bio."
            });
            _context.SaveChanges();

            _sut = new InstructorService(_context);
        }

        [Test]
        public async Task GetInstructorByIdAsync_ReturnsCorrectInstructor()
        {
            var expectedId = _context.Instructors.First().Id;

            var result = await _sut.GetInstructorByIdAsync(expectedId);

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedId, result.Id);
            Assert.AreEqual("John", result.FirstName);
            Assert.AreEqual("Doe", result.LastName);
            Assert.AreEqual("A sample bio.", result.Bio);
            Assert.AreEqual("photo.jpg", result.Photo);
        }
    }
}
