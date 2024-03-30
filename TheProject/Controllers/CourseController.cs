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
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await _courseService.GetAllCoursesAsync();

            return View(model);
        }

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

            return View(model);
        }

        //[Authorize(Roles = "user")]
        [HttpGet]
        public async Task<IActionResult> MyCourses()
        {
            string userId = GetUserId();
            var models = await _courseService.GetUserCoursesAsync(userId);

            return View(nameof(MyCourses), models);
        }

        //[Authorize(Roles = "user")]
        [HttpPost]
        public async Task<IActionResult> Join(Guid courseId)
        {
            try
            {
                var userId = GetUserId();
                await _courseService.AddCourseToCollectionAsync(courseId, userId);
            }
            catch (Exception)
            {
                throw;
            }

            return RedirectToAction(nameof(All));
        }

        //[Authorize(Roles = "user")]
        [HttpPost]
        public async Task<IActionResult> Leave(Guid courseId)
        {
            string userId = GetUserId();
            await _courseService.RemoveCourseFromCollectionAsync(courseId, userId);

            return RedirectToAction(nameof(MyCourses));
        }

        private string GetUserId()
        {
            return User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;
        }
    }
}
