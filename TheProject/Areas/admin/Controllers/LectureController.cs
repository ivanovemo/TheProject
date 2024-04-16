using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Globalization;
using TheProject.Core.Contracts;
using TheProject.Core.Models.Lecture;
using DateFormat = TheProject.Infrastructure.Constants.Constants.Date;


namespace TheProject.Areas.admin.Controllers
{
    [Area("admin")]
    [Route("admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = "admin")]
    public class LectureController : Controller
    {
        private readonly ILectureService _lectureService;
        public LectureController(ILectureService lectureService)
        {
            _lectureService = lectureService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new LectureViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(LectureViewModel model)
        {
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    TempData["LectureErrorMessages"] = error.ErrorMessage;
                }

                var courseId = HttpContext.Request.Query["courseId"].ToString();

                return RedirectToAction("Details", "Course", new { area = "", courseId });
            }

            DateTime startDate;

            if (!DateTime.TryParseExact(model.StartDate, "yyyy-MM-ddTHH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate))
            {
                ModelState.AddModelError(nameof(model.StartDate), $"Invalid format! The date should be in 'yyyy-MM-ddTHH:mm' format!");
            }

            try
            {
                await _lectureService.AddLectureAsync(model, startDate);
                ModelState.Clear();
                return RedirectToAction("Details", "Course", new { area = "", courseId = model.CourseId });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Date", ex.Message);
                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid lectureId)
        {
            if (lectureId == Guid.Empty)
            {
                return BadRequest();
            }
            var lecture = await _lectureService.GetLectureByIdAsync(lectureId);

            if (lecture == null)
            {
                return NotFound();
            }

            await _lectureService.DeleteLectureAsync(lectureId);
            
            return RedirectToAction("Details", "Course", new { area = "", courseId = lecture.CourseId });
        }
    }
}
