using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TheProject.Areas.admin.Contracts;
using TheProject.Areas.admin.Models;
using TheProject.Infrastructure.Data;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Areas.admin.Services
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public AdminService(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<List<UserRolesViewModel>> GetUserRolesViewModelAsync()
        {
            var users = _userManager.Users.ToList();
            var userRolesViewModel = new List<UserRolesViewModel>();
            foreach (var user in users)
            {
                var thisViewModel = new UserRolesViewModel
                {
                    UserId = user.Id,
                    Username = user.UserName,
                    Email = user.Email,
                    IsAdmin = await _userManager.IsInRoleAsync(user, "admin")
                };
                userRolesViewModel.Add(thisViewModel);
            }
            return userRolesViewModel;
        }

        public async Task ChangeUserRoleAsync(string userId, bool makeAdmin)
        {
            if (string.IsNullOrEmpty(userId) || !await _context.Users.AnyAsync(u => u.Id == userId))
            {
                throw new ArgumentException("Invalid user ID.");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (makeAdmin)
            {
                await _userManager.RemoveFromRoleAsync(user, "user");
                await _userManager.AddToRoleAsync(user, "admin");
            }
            else
            {
                await _userManager.RemoveFromRoleAsync(user, "admin");
                await _userManager.AddToRoleAsync(user, "user");
            }
        }
    }
}