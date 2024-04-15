using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(SeedUsers());
        }

        private List<User> SeedUsers()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "6b79f761-5a4e-4457-a53b-cfc7c36ab084",
                UserName = "user1",
                NormalizedUserName = "user1",
                Email = "user1@gmail.com",
                NormalizedEmail = "USER1@GMAIL.COM"
            };

            user.PasswordHash = hasher.HashPassword(user, "user123");
            users.Add(user);

            user = new User()
            {
                Id = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                UserName = "user2",
                NormalizedUserName = "user2",
                Email = "user2@gmail.com",
                NormalizedEmail = "USER2@GMAIL.COM"
            };

            user.PasswordHash = hasher.HashPassword(user, "user1234");
            users.Add(user);

            user = new User()
            {
                Id = "addd0c13-6a3f-4706-afc8-219f5e89badd",
                UserName = "user3",
                NormalizedUserName = "user3",
                Email = "user3@gmail.com",
                NormalizedEmail = "USER3@GMAIL.COM"
            };

            user.PasswordHash = hasher.HashPassword(user, "user12345");
            users.Add(user);

            user = new User()
            {
                Id = "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                UserName = "admin1",
                NormalizedUserName = "admin1",
                Email = "admin1@gmail.com",
                NormalizedEmail = "ADMIN1@GMAIL.COM"
            };

            user.PasswordHash = hasher.HashPassword(user, "admin123");
            users.Add(user);


            return users;
        }
    }
}