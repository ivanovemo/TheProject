using TheProject.Core.Models.Category;
using TheProject.Core.Models.Course;
using TheProject.Infrastructure.Data.Models;
using TheProject.Infrastructure.Helpers;

namespace TheProject.Core.Contracts
{
    public interface ICourseService
    {
        Task<PaginatedList<CourseViewModel>> GetAllCoursesAsync(string searchQuery = null!, int pageIndex = 1, int pageSize = 3);
        Task AddCourseAsync(CourseViewModel model, DateTime startDate, DateTime endDate);
        Task EditCourseAsync(Guid courseId, CourseViewModel model, DateTime startDate, DateTime endDate);
        Task DeleteCourseAsync(Guid courseId);
        Task<CourseViewModel> CourseDetailsAsync(Course currentCourse);
        Task<CourseViewModel> GetCourseViewModelByIdAsync(Guid id);
        Task<bool> CourseExistsAsync(Guid courseId);
        Task<Course?> GetCourseAsync(Guid courseId);
        Task<IEnumerable<CourseViewModel>> GetUserCoursesAsync(string userId);
        Task AddCourseToCollectionAsync(Guid courseId, string userId);
        Task RemoveCourseFromCollectionAsync(Guid courseId, string userId);
        Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync();
    }
}
