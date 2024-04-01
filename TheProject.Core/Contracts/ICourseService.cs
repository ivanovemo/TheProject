using TheProject.Core.Models.Category;
using TheProject.Core.Models.Course;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Core.Contracts
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseViewModel>> GetAllCoursesAsync();
        Task AddCourseAsync(CourseViewModel model, DateTime startDate, DateTime endDate);
        Task<CourseViewModel> CourseDetailsAsync(Course currentCourse);
        Task<bool> CourseExistsAsync(Guid courseId);
        Task<Course?> GetCourseAsync(Guid courseId);
        Task<IEnumerable<CourseViewModel>> GetUserCoursesAsync(string userId);
        Task AddCourseToCollectionAsync(Guid courseId, string userId);
        Task RemoveCourseFromCollectionAsync(Guid courseId, string userId);
        Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync();
    }
}
