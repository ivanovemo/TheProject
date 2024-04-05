using Microsoft.AspNetCore.Mvc;
using TheProject.Core.Contracts;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorService _instructorService;

        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        public async Task<IActionResult> Info(Guid instructorId)
        {
            var model = await _instructorService.GetInstructorByIdAsync(instructorId);

            if (model == null)
            {
                return BadRequest();
            }

            return View(model);
        }

    }
}