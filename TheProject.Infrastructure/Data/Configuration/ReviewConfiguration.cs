using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Infrastructure.Data.Configuration
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(SeedReviews());
        }

        private List<Review> SeedReviews()
        {
            var reviews = new List<Review>()
            {
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 8,
                    Description = "A comprehensive course that offers deep insights into full stack development.",
                    UserId = "6b79f761-5a4e-4457-a53b-cfc7c36ab084",
                    CourseId = Guid.Parse("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab")
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 9,
                    Description = "Excellent course on data science. Highly recommend for beginners and intermediates.",
                    UserId = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                    CourseId = Guid.Parse("6663d89a-3f07-4bea-b4f4-dc8b47efe599")
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 7,
                    Description = "Great insights into digital marketing strategies. Useful for all levels.",
                    UserId = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                    CourseId = Guid.Parse("412588b2-b00f-49dc-b261-04b65edfd9f3")
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 6,
                    Description = "Loved the practical approach to graphic design principles. The examples were very helpful.",
                    UserId = "addd0c13-6a3f-4706-afc8-219f5e89badd",
                    CourseId = Guid.Parse("557a4fcd-1f84-4487-a7bd-8240327c976b")
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 8,
                    Description = "The PMP prep course was detailed and well-structured. It helped me pass the exam on the first try.",
                    UserId = "addd0c13-6a3f-4706-afc8-219f5e89badd",
                    CourseId = Guid.Parse("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f")
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 10,
                    Description = "This course exceeded my expectations! The content was clear, and the projects were both challenging and rewarding.",
                    UserId = "addd0c13-6a3f-4706-afc8-219f5e89badd",
                    CourseId = Guid.Parse("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab")
                }
            };

            return reviews;
        }
    }
}