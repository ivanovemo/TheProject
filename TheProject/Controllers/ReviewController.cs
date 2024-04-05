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

        [Authorize(Roles = "user, admin")]
        [HttpPost]
        public async Task<IActionResult> Create(ReviewViewModel model)
        {
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
