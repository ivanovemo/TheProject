using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Infrastructure.Data.Configuration
{
    public class UserRolesConfiguration
    {
        public static async Task SeedUserRoles(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                var adminRoleExists = await roleManager.RoleExistsAsync("admin");
                if (!adminRoleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole("admin"));
                }

                var userRoleExists = await roleManager.RoleExistsAsync("user");
                if (!userRoleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole("user"));
                }

                var adminUser = await userManager.FindByEmailAsync("admin1@gmail.com");
                if (adminUser != null && !(await userManager.IsInRoleAsync(adminUser, "admin")))
                {
                    await userManager.AddToRoleAsync(adminUser, "admin");
                }

                var userUser = await userManager.FindByEmailAsync("user1@gmail.com");
                if (userUser != null && !(await userManager.IsInRoleAsync(userUser, "user")))
                {
                    await userManager.AddToRoleAsync(userUser, "user");
                }

                var secondUser = await userManager.FindByEmailAsync("user2@gmail.com");
                if (secondUser != null &&!(await userManager.IsInRoleAsync(secondUser, "user")))
                {
                    await userManager.AddToRoleAsync(secondUser, "user");
                }

                var thirdUser = await userManager.FindByEmailAsync("user3@gmail.com");
                if (thirdUser != null && !(await userManager.IsInRoleAsync(thirdUser, "user")))
                {
                    await userManager.AddToRoleAsync(thirdUser, "user");
                }
            }
        }
    }
}
