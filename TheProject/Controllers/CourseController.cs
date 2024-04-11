using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheProject.Core.Contracts;
namespace TheProject.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IReviewService _reviewService;
        private readonly ILectureService _lectureService;
        public CourseController(ICourseService courseService, IReviewService reviewService, ILectureService lectureService)
        {
            _courseService = courseService;
            _reviewService = reviewService;
            _lectureService = lectureService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All(string searchQuery, int pageIndex = 1)
        {
            const int pageSize = 6;
            var models = await _courseService.GetAllCoursesAsync(searchQuery, pageIndex, pageSize);

            ViewBag.HasNextPage = models.HasNextPage;
            ViewBag.PageIndex = pageIndex;

            return View(models);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(Guid courseId)
        {
            if (await _courseService.CourseExistsAsync(courseId) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var course = await _courseService.GetCourseAsync(courseId);

            if (course == null)
            {
                return BadRequest();
            }

            var model = await _courseService.CourseDetailsAsync(course);
            model.Reviews = await _reviewService.GetReviewsByCourseIdAsync(courseId);
            model.Lectures = await _lectureService.GetLecturesByCourseId(courseId);

            return View(model);
        }

        [Authorize(Roles = "user, admin")]
        [HttpGet]
        public async Task<IActionResult> MyCourses()
        {
            string userId = GetUserId();
            var models = await _courseService.GetUserCoursesAsync(userId);

            return View(nameof(MyCourses), models);
        }

        [Authorize(Roles = "user, admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Join(Guid courseId)
        {
            var userId = GetUserId();

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "User");
            }

            try
            {
                await _courseService.AddCourseToCollectionAsync(courseId, userId);
            }
            catch (Exception)
            {
                throw;
            }

            return RedirectToAction(nameof(MyCourses));
        }

        [Authorize(Roles = "user, admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Leave(Guid courseId)
        {
            string userId = GetUserId();
            await _courseService.RemoveCourseFromCollectionAsync(courseId, userId);

            return RedirectToAction(nameof(MyCourses));
        }

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
