using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Globalization;
using TheProject.Core.Contracts;
using TheProject.Core.Models.Course;
using DateFormat = TheProject.Infrastructure.Constants.Constants.Date;

namespace TheProject.Areas.admin.Controllers
{
    [Area("admin")]
    [Route("admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = "admin")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new CourseViewModel()
            {
                Categories = await _courseService.GetCategoriesAsync()
            };

            return View(model);
        }

        public async Task<IActionResult> Add(CourseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = await _courseService.GetCategoriesAsync();
                return View(model);
            }

            DateTime startDate;
            DateTime endDate;

            if (!DateTime.TryParseExact(model.StartDate, DateFormat.Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate))
            {
                ModelState.AddModelError(nameof(model.StartDate), $"Invalid format! The date should be in '{DateFormat.Format}' format!");
            }

            if (!DateTime.TryParseExact(model.EndDate, DateFormat.Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate))
            {
                ModelState.AddModelError(nameof(model.EndDate), $"Invalid format! The date should be in '{DateFormat.Format}' format!");
            }

            try
            {
                await _courseService.AddCourseAsync(model, startDate, endDate);
                ModelState.Clear();
                return RedirectToAction("All", "Course", new { area = "" });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Date", ex.Message);
                model.Categories = await _courseService.GetCategoriesAsync();
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid courseId)
        {
            if (await _courseService.CourseExistsAsync(courseId) == false)
            {
                return BadRequest();
            }

            var model = await _courseService.GetCourseViewModelByIdAsync(courseId);
            model.Categories = await _courseService.GetCategoriesAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid courseId, CourseViewModel model)
        {
            if (await _courseService.CourseExistsAsync(courseId) == false)
            {
                return BadRequest();
            }


            if (ModelState.IsValid == false)
            {
                model.Categories = await _courseService.GetCategoriesAsync();

                return View(model);
            }


            DateTime startDate;
            DateTime endDate;

            if (!DateTime.TryParseExact(model.StartDate, DateFormat.Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate))
            {
                ModelState.AddModelError(nameof(model.StartDate), $"Invalid format! The date should be in '{DateFormat.Format}' format!");
            }

            if (!DateTime.TryParseExact(model.EndDate, DateFormat.Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate))
            {
                ModelState.AddModelError(nameof(model.EndDate), $"Invalid format! The date should be in '{DateFormat.Format}' format!");
            }

            await _courseService.EditCourseAsync(courseId, model, startDate, endDate);

            return RedirectToAction("Details", "Course", new { area = "", courseId });
        }


        [HttpPost]
        public async Task<IActionResult> Delete(Guid courseId)
        {
            try
            {
                await _courseService.DeleteCourseAsync(courseId);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return RedirectToAction("All", "Course", new { area = "" });
            }

            return RedirectToAction("All", "Course", new { area = "" });
        }
    }
}
