﻿using Microsoft.EntityFrameworkCore;
using TheProject.Core.Contracts;
using TheProject.Core.Models.Category;
using TheProject.Core.Models.Course;
using TheProject.Core.Models.Instructor;
using TheProject.Infrastructure.Data;
using TheProject.Infrastructure.Data.Models;
using TheProject.Infrastructure.Helpers;
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

        public async Task<PaginatedList<CourseViewModel>> GetAllCoursesAsync(string searchQuery, int pageIndex = 1, int pageSize = 3)
        {
            IQueryable<Course> query = _context.Courses;

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query = query.Where(c => EF.Functions.Like(c.Title, $"%{searchQuery}%"));
            }

            var totalCourses = await query.CountAsync();

            var courses = await query
                .Include(c => c.Category)
                .Include(c => c.Instructor)
                .OrderBy(c => c.StartDate)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
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
                    Instructor = new InstructorViewModel()
                    {
                        Id = c.Instructor.Id,
                        FirstName = c.Instructor.FirstName,
                        LastName = c.Instructor.LastName,
                    }
                })
                .ToListAsync();

            return new PaginatedList<CourseViewModel>(courses, totalCourses, pageIndex, pageSize);
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
                Description = currentCourse.Description,
                Category = courseCategory!.Name,
                StartDate = currentCourse.StartDate.ToString(DateFormat.Format),
                EndDate = currentCourse.EndDate.ToString(DateFormat.Format),
                Instructor = new InstructorViewModel()
                {
                    Id = currentCourse.Instructor.Id,
                    FirstName = currentCourse.Instructor.FirstName,
                    LastName = currentCourse.Instructor.LastName,
                    Photo = currentCourse.Instructor.Photo
                },
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
                            .Include(c => c.Category)
                            .Include(c => c.Reviews)
                                .ThenInclude(r => r.User)
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
                .Select(uc => new CourseViewModel()
                {
                    Id = uc.Course.Id,
                    Title = uc.Course.Title,
                    Instructor = new InstructorViewModel()
                    {
                        Id = uc.Course.Instructor.Id,
                        FirstName = uc.Course.Instructor.FirstName,
                        LastName = uc.Course.Instructor.LastName,
                    },
                    StartDate = uc.Course.StartDate.ToString(DateFormat.Format),
                    EndDate = uc.Course.EndDate.ToString(DateFormat.Format),
                    ImageUrl = uc.Course.ImageUrl,
                    Interested = uc.Course.Interested,
                    Category = uc!.Course.Category.Name
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
                courseToDecrease!.Interested--;

                user.UsersCourses.Remove(existingCourse);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync()
        {
            return await _context.Categories
                .AsNoTracking()
                .Select(c => new CategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task AddCourseAsync(CourseViewModel model, DateTime startDate, DateTime endDate)
        {
            var course = new Course()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Instructor = new Instructor()
                {
                    FirstName = model.Instructor.FirstName,
                    LastName = model.Instructor.LastName,
                    Bio = model.Instructor.Bio,
                    Photo = model.Instructor.Photo
                },
                ImageUrl = model.ImageUrl,
                StartDate = startDate,
                EndDate = endDate,
                Description = model.Description,
                CategoryId = model.CategoryId
            };

            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCourseAsync(Guid courseId)
        {
            var course = await _context.Courses.FindAsync(courseId);

            if (course is null)
            {
                throw new Exception($"Something went wrong!");
            }

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
        }

        public async Task EditCourseAsync(Guid courseId, CourseViewModel model, DateTime startDate, DateTime endDate)
        {
            var course = await GetCourseAsync(courseId);

            if (course != null)
            {
                course.Title = model.Title;
                course.Instructor.FirstName = model.Instructor.FirstName;
                course.Instructor.LastName = model.Instructor.LastName;
                course.Instructor.Photo = model.Instructor.Photo;
                course.Instructor.Bio = model.Instructor.Bio;
                course.ImageUrl = model.ImageUrl;
                course.StartDate = startDate;
                course.EndDate = endDate;
                course.Description = model.Description;
                course.CategoryId = model.CategoryId;

                await _context.SaveChangesAsync();
            }
        }

        public async Task<CourseViewModel> GetCourseViewModelByIdAsync(Guid courseId)
        {
            var course = await GetCourseAsync(courseId);

            if (course == null)
            {
                throw new ArgumentException("Course not found");
            }

            var model = new CourseViewModel()
            {
                Id = course.Id,
                Title = course.Title,
                Instructor = new InstructorViewModel()
                {
                    Id = course.Instructor.Id,
                    FirstName = course.Instructor.FirstName,
                    LastName = course.Instructor.LastName,
                    Bio = course.Instructor.Bio,
                    Photo = course.Instructor.Photo
                },
                ImageUrl = course.ImageUrl,
                StartDate = course.StartDate.ToString(DateFormat.Format),
                EndDate = course.EndDate.ToString(DateFormat.Format),
                Description = course.Description,
                Interested = course.Interested,
                CategoryId = course.CategoryId ?? 1,
                Category = course.Category.Name,
                Categories = await GetCategoriesAsync(),
            };

            return model;
        }
    }
}
