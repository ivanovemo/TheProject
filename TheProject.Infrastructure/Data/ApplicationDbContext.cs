using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheProject.Infrastructure.Data.Configuration;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserCourse>()
                .HasKey(uc => new
                {
                    uc.UserId,
                    uc.CourseId
                });

            builder.Entity<User>()
                .Property(u => u.UserName)
                .HasMaxLength(20)
                .IsRequired();

            builder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(50)
                .IsRequired();

            builder.Entity<Course>()
                .HasMany(c => c.Lectures)
                .WithOne(l => l.Course)
                .HasForeignKey(l => l.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Course>()
                .HasMany(c => c.Reviews)
                .WithOne(r => r.Course)
                .HasForeignKey(r => r.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new InstructorConfiguration());
            builder.ApplyConfiguration(new LecturesConfiguration());
            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Lecture> Lectures { get; set; } = null!;
        public DbSet<Instructor> Instructors { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;

    }
}
