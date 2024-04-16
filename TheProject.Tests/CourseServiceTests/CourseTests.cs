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
using DateFormat = TheProject.Infrastructure.Constants.Constants.Date;
using Microsoft.VisualBasic;

namespace TheProject.Tests.CourseServiceTests
{
    [TestFixture]
    public class CourseTests
    {
        private ApplicationDbContext _context;
        private ICourseService _sut;
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
            _sut = new CourseService(_context);

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
        public async Task CourseDetailsAsync_ReturnsCorrectCourseViewModel()
        {
            var result = await _sut.CourseDetailsAsync(_course);

            Assert.IsNotNull(result);
            Assert.AreEqual(_course.Title, result.Title);
            Assert.AreEqual(_course.Description, result.Description);
            Assert.AreEqual(_course.ImageUrl, result.ImageUrl);
            Assert.AreEqual(_category.Name, result.Category);
            Assert.AreEqual(_course.StartDate.ToString(DateFormat.Format), result.StartDate);
            Assert.AreEqual(_course.EndDate.ToString(DateFormat.Format), result.EndDate);
            Assert.AreEqual(_instructor.FirstName, result.Instructor.FirstName);
            Assert.AreEqual(_instructor.LastName, result.Instructor.LastName);
            Assert.AreEqual(_instructor.Photo, result.Instructor.Photo);
        }

        [Test]
        public async Task DeleteCourseAsync_DeletesCourseSuccessfully()
        {
            await _sut.DeleteCourseAsync(_course.Id);

            var deletedCourse = await _context.Courses.FindAsync(_course.Id);
            Assert.IsNull(deletedCourse);
        }

        [Test]
        public async Task AddCourseAsync_AddsCourseCorrectly()
        {
            var newCourseViewModel = new CourseViewModel
            {
                Title = "New Course",
                Description = "Description of New Course",
                StartDate = DateTime.Now.AddDays(5).ToString("MM/dd/yyyy"),
                EndDate = DateTime.Now.AddDays(10).ToString("MM/dd/yyyy"),
                CategoryId = _category.Id,
                ImageUrl = "new_image.jpg"
            };

            await _sut.AddCourseAsync(newCourseViewModel, DateTime.Now.AddDays(5), DateTime.Now.AddDays(10));

            var addedCourse = await _context.Courses.FirstOrDefaultAsync(c => c.Title == newCourseViewModel.Title);
            Assert.IsNotNull(addedCourse);
            Assert.AreEqual(newCourseViewModel.Title, addedCourse.Title);
            Assert.AreEqual(newCourseViewModel.Description, addedCourse.Description);
            Assert.AreEqual(newCourseViewModel.ImageUrl, addedCourse.ImageUrl);
        }

        [Test]
        public async Task GetCourseViewModelByIdAsync_ReturnsCourseViewModel()
        {
            var result = await _sut.GetCourseViewModelByIdAsync(_course.Id);

            Assert.IsNotNull(result);
            Assert.AreEqual(_course.Title, result.Title);
            Assert.AreEqual(_course.Description, result.Description);
            Assert.AreEqual(_course.ImageUrl, result.ImageUrl);
            Assert.AreEqual(_course.StartDate.ToString(DateFormat.Format), result.StartDate);
            Assert.AreEqual(_course.EndDate.ToString(DateFormat.Format), result.EndDate);
            Assert.AreEqual(_instructor.FirstName, result.Instructor.FirstName);
        }

        [Test]
        public async Task EditCourseAsync_UpdatesCourseCorrectly()
        {
            var updatedModel = new CourseViewModel
            {
                Title = "Updated Title",
                Description = "Updated Description",
                ImageUrl = "updated_image.jpg",
                StartDate = DateTime.Now.AddDays(10).ToString(DateFormat.Format),
                EndDate = DateTime.Now.AddDays(20).ToString(DateFormat.Format),
                Instructor = new InstructorViewModel
                {
                    FirstName = "Updated FirstName",
                    LastName = "Updated LastName",
                    Photo = "updated_photo.jpg",
                    Bio = "Updated Bio"
                },
                CategoryId = _category.Id
            };

            await _sut.EditCourseAsync(_course.Id, updatedModel, DateTime.Now.AddDays(10), DateTime.Now.AddDays(20));

            var updatedCourse = await _context.Courses.Include(c => c.Instructor).FirstOrDefaultAsync(c => c.Id == _course.Id);
            Assert.AreEqual(updatedModel.Title, updatedCourse.Title);
            Assert.AreEqual(updatedModel.Description, updatedCourse.Description);
            Assert.AreEqual(updatedModel.ImageUrl, updatedCourse.ImageUrl);
            Assert.AreEqual(updatedModel.StartDate, updatedCourse.StartDate.ToString(DateFormat.Format));
            Assert.AreEqual(updatedModel.EndDate, updatedCourse.EndDate.ToString(DateFormat.Format));
            Assert.AreEqual(updatedModel.Instructor.FirstName, updatedCourse.Instructor.FirstName);
            Assert.AreEqual(updatedModel.Instructor.LastName, updatedCourse.Instructor.LastName);
        }

        [Test]
        public async Task GetUserCoursesAsync_ReturnsCorrectCoursesForUser()
        {
            var userCourse = new UserCourse
            {
                User = _user,
                Course = _course
            };
            _context.UserCourses.Add(userCourse);
            await _context.SaveChangesAsync();

            var result = await _sut.GetUserCoursesAsync(_user.Id);

            var courses = result.ToList();
            Assert.AreEqual(1, courses.Count);
            Assert.AreEqual(_course.Id, courses[0].Id);
            Assert.AreEqual(_course.Title, courses[0].Title);
        }

        [Test]
        public async Task AddCourseToCollectionAsync_AddsCourseSuccessfully()
        {
            await _sut.AddCourseToCollectionAsync(_course.Id, _user.Id);

            var result = await _context.UserCourses.FirstOrDefaultAsync(uc => uc.UserId == _user.Id && uc.CourseId == _course.Id);
            Assert.IsNotNull(result);
            Assert.AreEqual(21, _course.Interested);
        }


        [Test]
        public async Task RemoveCourseFromCollectionAsync_DoesNothing_WhenCourseNotInCollection()
        {
            var nonExistentCourseId = Guid.NewGuid();

            await _sut.RemoveCourseFromCollectionAsync(nonExistentCourseId, _user.Id);

            var result = _context.UserCourses.FirstOrDefault(uc => uc.UserId == _user.Id && uc.CourseId == nonExistentCourseId);
            Assert.IsNull(result);
        }


        [Test]
        public async Task GetCategoriesAsync_ReturnsAllCategories()
        {
            var result = await _sut.GetCategoriesAsync();

            var categories = result.ToList();
            Assert.AreEqual(1, categories.Count);
            Assert.AreEqual(_category.Name, categories[0].Name);
        }

        [Test]
        public async Task CourseExistsAsync_ReturnsTrue_WhenCourseExists()
        {
            var result = await _sut.CourseExistsAsync(_course.Id);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task CourseExistsAsync_ReturnsFalse_WhenCourseDoesNotExist()
        {
            var nonExistentCourseId = Guid.NewGuid();

            var result = await _sut.CourseExistsAsync(nonExistentCourseId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetCourseAsync_ReturnsCourse_WithDetails_WhenCourseExists()
        {
            var result = await _sut.GetCourseAsync(_course.Id);

            Assert.IsNotNull(result);
            Assert.AreEqual(_course.Id, result.Id);
            Assert.AreEqual(_instructor.Id, result.Instructor.Id);
            Assert.AreEqual(_category.Id, result.Category.Id);
            Assert.IsNotEmpty(result.Reviews);
            Assert.AreEqual(1, result.Reviews.Count);
            Assert.AreEqual(_review.Description, result.Reviews.First().Description);
        }

        [Test]
        public async Task GetCourseAsync_ReturnsNull_WhenCourseDoesNotExist()
        {
            var nonExistentCourseId = Guid.NewGuid();

            var result = await _sut.GetCourseAsync(nonExistentCourseId);

            Assert.IsNull(result);
        }

        [Test]
        public async Task GetAllCoursesAsync_ReturnsPaginatedResults()
        {
            for (int i = 2; i <= 10; i++)
            {
                _context.Courses.Add(new Course
                {
                    Id = Guid.NewGuid(),
                    Title = "Calculus " + i,
                    Description = "A course on advanced topics " + i,
                    StartDate = DateTime.Now.AddDays(i),
                    EndDate = DateTime.Now.AddDays(30 + i),
                    CategoryId = _category.Id,
                    Instructor = new Instructor()
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "FirstName" + i,
                        LastName = "LastName" + i,
                        Bio = "Bio" + i,
                        Photo = "Photo" + i
                    },
                    ImageUrl = "image" + i + ".jpg",
                    Interested = i * 10
                });
            }
            await _context.SaveChangesAsync();

            var firstPageResult = await _sut.GetAllCoursesAsync("", 1, 6);
            var secondPageResult = await _sut.GetAllCoursesAsync("", 2, 4);

            Assert.AreEqual(6, firstPageResult.Count);
            Assert.AreEqual(4, secondPageResult.Count);
            Assert.AreEqual(10, firstPageResult.Count + secondPageResult.Count);
            Assert.AreNotEqual(firstPageResult[0].Id, secondPageResult[0].Id);
        }

        [Test]
        public async Task GetAllCoursesAsync_FiltersBySearchQuery()
        {
            var searchResults = await _sut.GetAllCoursesAsync("Calculus", 1, 6);

            Assert.IsTrue(searchResults.All(c => c.Title.Contains("Calculus")));
            Assert.AreEqual(1, searchResults.Count);
        }

        [Test]
        public async Task GetAllCoursesAsync_LoadsRelatedData()
        {
            var results = await _sut.GetAllCoursesAsync("", 1, 1);

            var course = results.First();
            Assert.IsNotNull(course.Instructor);
            Assert.IsNotNull(course.Category);
            Assert.AreEqual(_instructor.FirstName, course.Instructor.FirstName);
            Assert.AreEqual(_category.Name, course.Category);
        }

        [Test]
        public async Task GetAllCoursesAsync_ReturnsEmpty_WhenNoMatch()
        {
            var results = await _sut.GetAllCoursesAsync("Nonexistent", 1, 10);

            Assert.IsEmpty(results);
        }
    }
}