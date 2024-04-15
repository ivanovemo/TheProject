namespace TheProject.Areas.admin.Models
{
    public class UserRolesViewModel
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}