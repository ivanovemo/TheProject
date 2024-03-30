using Microsoft.EntityFrameworkCore;
using TheProject.Core.Contracts;
using TheProject.Core.Models.Course;
using TheProject.Infrastructure.Data;
using TheProject.Infrastructure.Data.Models;
using DateFormat = TheProject.Infrastructure.Constants.Constants.Date;

namespace TheProject.Core.Services
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationDbContext _context;

        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CourseViewModel>> GetAllCoursesAsync()
        {
            var courses = await _context.Courses
                .Include(c => c.Category)
                .Include(c => c.Instructor)
                .Select(c => new CourseViewModel
                {
                    Id = c.Id,
                    Title = c.Title,
                    Category = c.Category.Name,
                    ImageUrl = c.ImageUrl,
                    StartDate = c.StartDate.ToString(DateFormat.Format),
                    Description = c.Description,
                    Interested = c.Interested,
                    EndDate = c.EndDate.ToString(DateFormat.Format),
                    Instructor = c.Instructor.FirstName + " " + c.Instructor.LastName,
                })
                .ToListAsync();

            return courses;
        }

        public async Task<CourseViewModel> CourseDetailsAsync(Course currentCourse)
        {
            var courseCategory = await _context.Categories.FirstOrDefaultAsync(c => c.Id == currentCourse.CategoryId);
            var courseInstructor = await _context.Instructors.FirstOrDefaultAsync(v => v.Id == currentCourse.Instructor.Id);
            
            var model = new CourseViewModel()
            {
                Id = currentCourse.Id,
                Title = currentCourse.Title,
                ImageUrl = currentCourse.ImageUrl,
                InstructorPhoto = currentCourse.Instructor.Photo,
                Description = currentCourse.Description,
                Category = courseCategory!.Name,
                StartDate = currentCourse.StartDate.ToString(DateFormat.Format),
                EndDate = currentCourse.EndDate.ToString(DateFormat.Format),
                Instructor = $"{currentCourse.Instructor.FirstName} {currentCourse.Instructor.LastName}",
                Interested = currentCourse.Interested
            };

            return model;
        }

        public async Task<bool> CourseExistsAsync(Guid courseId)
        {
            return await _context.Courses.FindAsync(courseId) is null ? false : true;
        }

        public async Task<Course?> GetCourseAsync(Guid courseId)
        {
            return await _context.Courses
                            .Include(c => c.Instructor)
                            .FirstOrDefaultAsync(c => c.Id == courseId);
        }

        public async Task<IEnumerable<CourseViewModel>> GetUserCoursesAsync(string userId)
        {
            var user = await _context.Users
                .Where(u => u.Id == userId)
                .Include(u => u.UsersCourses)
                    .ThenInclude(uc => uc.Course)
                        .ThenInclude(c => c.Category)
                .Include(u => u.UsersCourses)
                    .ThenInclude(uc => uc.Course)
                        .ThenInclude(c => c.Instructor)
                .FirstOrDefaultAsync();


            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            return user.UsersCourses
                .Select(e => new CourseViewModel()
                {
                    Id = e.Course.Id,
                    Title = e.Course.Title,
                    Instructor = $"{e.Course.Instructor.FirstName} {e.Course.Instructor.LastName}",
                    ImageUrl = e.Course.ImageUrl,
                    Interested = e.Course.Interested,
                    Category = e?.Course.Category?.Name
                });
        }

        public async Task AddCourseToCollectionAsync(Guid courseId, string userId)
        {
            var user = await _context.Users
                 .Where(u => u.Id == userId)
                 .Include(u => u.UsersCourses)
                 .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            var existingCourse = await _context.Courses.FirstOrDefaultAsync(c => c.Id == courseId);

            if (existingCourse == null)
            {
                throw new ArgumentException("Invalid course ID");
            }

            if (!user.UsersCourses.Any(e => e.CourseId == courseId))
            {
                existingCourse.Interested++;

                user.UsersCourses.Add(new UserCourse()
                {
                    CourseId = existingCourse.Id,
                    UserId = user.Id,
                    Course = existingCourse,
                    User = user
                });


                await _context.SaveChangesAsync();
            }
        }

        public async Task RemoveCourseFromCollectionAsync(Guid courseId, string userId)
        {
            var user = await _context.Users
                .Where(u => u.Id == userId)
                .Include(u => u.UsersCourses)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            var existingCourse = user.UsersCourses.FirstOrDefault(e => e.CourseId == courseId);

            if (existingCourse != null)
            {
                var courseToDecrease = await GetCourseAsync(courseId);
                courseToDecrease.Interested--;

                user.UsersCourses.Remove(existingCourse);
                await _context.SaveChangesAsync();
            }
        }
    }
}
