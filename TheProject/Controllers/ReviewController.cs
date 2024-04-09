using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheProject.Core.Contracts;
using TheProject.Core.Models.Review;

namespace TheProject.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost]
        [Authorize(Roles = "user, admin")]
        public async Task<IActionResult> Create(ReviewViewModel model)
        {
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    TempData["ReviewErrorMessages"] = error.ErrorMessage;
                }

                var courseId = HttpContext.Request.Query["courseId"].ToString();

                return RedirectToAction("Details", "Course", new { area = "", courseId });
            }

            string userId = GetUserId();

            if (string.IsNullOrEmpty(userId))
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _reviewService.AddReviewAsync(model, userId);
                return RedirectToAction("Details", "Course", new { courseId = model.CourseId });
            }

            return View(model);
        }
        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
