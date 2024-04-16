using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TheProject.Areas.admin.Contracts;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Areas.admin.Controllers
{
    [Authorize(Roles = "admin")]
    [Area("admin")]
    [Route("admin/[controller]/[Action]/{id?}")]
    public class AdminController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService, UserManager<User> userManager)
        {
            _adminService = adminService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Menu()
        {
            var userRolesViewModel = await _adminService.GetUserRolesViewModelAsync();
            return View(userRolesViewModel);
        }

        public async Task<IActionResult> ChangeRole(string userId, bool makeAdmin)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (User.IsInRole("admin") && User.Identity.Name != user.UserName && user.UserName != "admin1")
            {
                await _adminService.ChangeUserRoleAsync(userId, makeAdmin);
            }
            return RedirectToAction(nameof(Menu));
        }
    }
}