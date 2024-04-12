using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using TheProject.Core.Models.Course;
using TheProject.Core.Services;
using TheProject.Infrastructure.Data;
using TheProject.Core.Contracts;
using TheProject.Infrastructure.Data.Models;
using TheProject.Core.Models.Instructor;

namespace TheProject.Tests.CourseServiceTests
{
    [TestFixture]
    public class CourseTests
    {
        private ApplicationDbContext _context;
        private ICourseService _sut;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(options);
            _sut = new CourseService(_context);
        }

        [Test]
        public async Task GetAllCoursesAsync_ReturnsPaginatedResults()
        {
            for (int i = 1; i <= 10; i++)
            {
                _context.Categories.Add(new Category { Id = i, Name = "Category" + i });
                _context.Instructors.Add(new Instructor
                {
                    Id = Guid.NewGuid(),
                    FirstName = "FirstName" + i,
                    LastName = "LastName" + i,
                    Bio = "Bio" + i,
                    Photo = "Photo" + i
                });
            }

            await _context.SaveChangesAsync();

            for (int i = 1; i <= 10; i++)
            {
                var instructor = await _context.Instructors.FirstOrDefaultAsync(ins => ins.FirstName == "FirstName" + i);
                await _context.Courses.AddAsync(new Course
                {
                    Id = Guid.NewGuid(),
                    Title = "Title" + i,
                    Instructor = instructor,
                    ImageUrl = "Image" + i,
                    StartDate = DateTime.Now.AddDays(i),
                    EndDate = DateTime.Now.AddDays(i + 1),
                    Description = "Description" + i,
                    CategoryId = i,
                    Interested = i
                });
            }
            await _context.SaveChangesAsync();

            var result = await _sut.GetAllCoursesAsync("", 1, 5);
            var result2 = await _sut.GetAllCoursesAsync("", 1, 10);

            Assert.AreEqual(5, result.Count);
            Assert.AreEqual(10, result2.Count);
        }

        [Test]
        public async Task DeleteCourseAsync_DeletesCourseSuccessfully()
        {
            var courseId = Guid.NewGuid();
            _context.Categories.Add(new Category { Id = 1, Name = "Category" });
            _context.Instructors.Add(new Instructor
            {
                Id = Guid.NewGuid(),
                FirstName = "FirstName",
                LastName = "LastName",
                Bio = "Bio",
                Photo = "Photo",
                CourseId = courseId
            });

            var instructor = await _context.Instructors.FirstOrDefaultAsync(ins => ins.FirstName == "FirstName");

            var course = new Course
            {
                Id = courseId,
                Title = "Title",
                Instructor = instructor,
                ImageUrl = "Image",
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(1),
                Description = "Description",
                CategoryId = 1,
                Interested = 20
            };

            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();

            await _sut.DeleteCourseAsync(course.Id);

            var deletedCourse = await _context.Courses.FindAsync(course.Id);
            Assert.IsNull(deletedCourse);
        }

        [Test]
        public async Task AddCourseAsync_AddsCourseCorrectly()
        {
            _context.Categories.Add(new Category { Id = 1, Name = "Category" });
            var courseViewModel = new CourseViewModel
            {
                Title = "New Course",
                Description = "New Description",
                StartDate = DateTime.Now.ToString(),
                EndDate = DateTime.Now.AddDays(1).ToString(),
                CategoryId = 1
            };

            await _sut.AddCourseAsync(courseViewModel, DateTime.Now, DateTime.Now.AddDays(1));

            var addedCourse = await _context.Courses.FirstOrDefaultAsync(c => c.Title == "New Course");
            Assert.IsNotNull(addedCourse);
            Assert.AreEqual(courseViewModel.Title, addedCourse.Title);
            Assert.AreEqual(courseViewModel.Interested, addedCourse.Interested);
            Assert.AreEqual(courseViewModel.StartDate, addedCourse.StartDate.ToString());
            Assert.AreEqual(courseViewModel.EndDate, addedCourse.EndDate.ToString());
            Assert.AreEqual(courseViewModel.CategoryId, addedCourse.CategoryId);
            Assert.AreEqual(courseViewModel.Description, addedCourse.Description);
            Assert.AreEqual(courseViewModel.Reviews.Count(), addedCourse.Reviews.Count());
            Assert.AreEqual(courseViewModel.Lectures.Count(), addedCourse.Lectures.Count());
            Assert.AreEqual(courseViewModel.ImageUrl, addedCourse.ImageUrl);
        }

        [Test]
        public async Task GetCourseViewModelByIdAsync_ReturnsCourseViewModel()
        {
            var courseId = Guid.NewGuid();
            _context.Categories.Add(new Category { Id = 1, Name = "Category" });
            _context.Instructors.Add(new Instructor
            {
                Id = Guid.NewGuid(),
                FirstName = "FirstName",
                LastName = "LastName",
                Bio = "Bio",
                Photo = "Photo",
                CourseId = courseId
            });

            var instructor = await _context.Instructors.FirstOrDefaultAsync(ins => ins.FirstName == "FirstName");

            var course = new Course
            {
                Id = courseId,
                Title = "Existing Course",
                Description = "A good course",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(10),
                CategoryId = 1,
                Instructor = instructor
            };
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();

            var result = await _sut.GetCourseViewModelByIdAsync(course.Id);

            Assert.IsNotNull(result);
            Assert.AreEqual(course.Title, result.Title);
        }

        [Test]
        public async Task CourseExistsAsync_ReturnsTrue_WhenCourseExists()
        {
            var courseId = Guid.NewGuid();
            _context.Categories.Add(new Category { Id = 1, Name = "Category" });
            _context.Instructors.Add(new Instructor
            {
                Id = Guid.NewGuid(),
                FirstName = "FirstName",
                LastName = "LastName",
                Bio = "Bio",
                Photo = "Photo",
                CourseId = courseId
            });

            var instructor = await _context.Instructors.FirstOrDefaultAsync(ins => ins.FirstName == "FirstName");

            var course = new Course()
            {
                Id = courseId,
                Title = "Existing Course",
                Description = "Existing description",
                Instructor = instructor,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(10),
                ImageUrl = "Imge existing",
                CategoryId = 1
            };

            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();

            var result = await _sut.CourseExistsAsync(courseId);

            Assert.IsTrue(result);
        }
    }
}