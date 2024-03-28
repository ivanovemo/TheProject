using Microsoft.AspNetCore.Identity;

namespace TheProject.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        public IList<UserCourse> UsersCourses { get; set; } = new List<UserCourse>();
        public IList<Review> Reviews { get; set; } = new List<Review>();
    }
}
