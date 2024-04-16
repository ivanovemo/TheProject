using TheProject.Areas.admin.Models;

namespace TheProject.Areas.admin.Contracts
{
    public interface IAdminService
    {
        Task ChangeUserRoleAsync(string userId, bool makeAdmin);
        Task<List<UserRolesViewModel>> GetUserRolesViewModelAsync();
    }
}
