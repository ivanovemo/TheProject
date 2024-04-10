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
                    Rating = 9,
                    Description = "An incredibly comprehensive course that offered deep insights into full stack development with practical projects. Highly recommend for beginners and intermediate developers.",
                    UserId = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                    CourseId = Guid.Parse("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 8,
                    Description = "This course was detailed with plenty of hands-on exercises. However, some prerequisites in JavaScript would have been helpful to mention for absolute beginners.",
                    UserId = "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                    CourseId = Guid.Parse("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 10,
                    Description = "Outstanding content and delivery on complex topics. The practical sessions were particularly beneficial. A must-take course for aspiring data scientists.",
                    UserId = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                    CourseId = Guid.Parse("6663d89a-3f07-4bea-b4f4-dc8b47efe599"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 9,
                    Description = "Provides a robust foundation in data science. The course pace is fast but manageable. Python knowledge is a must to keep up.",
                    UserId = "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                    CourseId = Guid.Parse("6663d89a-3f07-4bea-b4f4-dc8b47efe599"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 7,
                    Description = "Covers all the basics of digital marketing. Some topics could use more depth, but overall a good starter course.",
                    UserId = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                    CourseId = Guid.Parse("412588b2-b00f-49dc-b261-04b65edfd9f3"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 8,
                    Description = "Great insights into digital marketing trends and tools. I particularly enjoyed the case studies and practical examples.",
                    UserId = "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                    CourseId = Guid.Parse("412588b2-b00f-49dc-b261-04b65edfd9f3"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 9,
                    Description = "A fascinating journey through the basics of graphic design. The course is well-structured, engaging, and creatively stimulating.",
                    UserId = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                    CourseId = Guid.Parse("557a4fcd-1f84-4487-a7bd-8240327c976b"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 8,
                    Description = "Solid introduction to graphic design principles. Would appreciate more advanced modules for further learning.",
                    UserId = "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                    CourseId = Guid.Parse("557a4fcd-1f84-4487-a7bd-8240327c976b"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 8,
                    Description = "The course does an excellent job preparing for the PMP exam with detailed materials and practice questions. Some lessons felt a bit dry.",
                    UserId = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                    CourseId = Guid.Parse("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 7,
                    Description = "Provides a comprehensive overview of project management principles. Would benefit from more interactive content to keep the engagement high.",
                    UserId = "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                    CourseId = Guid.Parse("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 10,
                    Description = "Inspirational course that offers practical advice on living more sustainably. It's comprehensive and thought-provoking.",
                    UserId = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                    CourseId = Guid.Parse("ae35af86-a051-46f0-9aef-980d4e7585ac"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 9,
                    Description = "A great introduction to sustainability. It covers a wide range of topics and provides actionable steps to make a difference.",
                    UserId = "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                    CourseId = Guid.Parse("ae35af86-a051-46f0-9aef-980d4e7585ac"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 8,
                    Description = "Engaging and hands-on introduction to robotics. While some technical aspects can be challenging, the course is extremely rewarding.",
                    UserId = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                    CourseId = Guid.Parse("c65ee8c7-189a-4730-9171-d89324a534de"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 7,
                    Description = "A good foundational course in robotics that could be improved by updating some of the course materials and resources.",
                    UserId = "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                    CourseId = Guid.Parse("c65ee8c7-189a-4730-9171-d89324a534de"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 9,
                    Description = "Excellent course for beginners. The interactive exercises and practical conversation practice were very helpful.",
                    UserId = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                    CourseId = Guid.Parse("f7b36bbc-397a-411d-b15c-b51355eb4465"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 8,
                    Description = "A solid introduction to Spanish that makes learning a new language less daunting. More advanced follow-up courses would be appreciated.",
                    UserId = "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                    CourseId = Guid.Parse("f7b36bbc-397a-411d-b15c-b51355eb4465"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 10,
                    Description = "Extremely valuable course offering crucial insights into mental health support. Highly recommended for everyone.",
                    UserId = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                    CourseId = Guid.Parse("78a56892-9dba-42cf-9328-e2cf026a5b97"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 9,
                    Description = "Important and timely content that's presented in an accessible way. This course is essential for anyone looking to understand more about mental health.",
                    UserId = "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                    CourseId = Guid.Parse("78a56892-9dba-42cf-9328-e2cf026a5b97"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 9,
                    Description = "This course was a journey of discovery into the art of storytelling. The prompts and feedback helped me grow my writing in ways I hadn't imagined.",
                    UserId = "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                    CourseId = Guid.Parse("6d38c7e6-84eb-411c-a528-53caecbdf5a5"),
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 8,
                    Description = "A great primer for aspiring writers, packed with engaging exercises and insightful tips. More content on novel writing would be beneficial.",
                    UserId = "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                    CourseId = Guid.Parse("6d38c7e6-84eb-411c-a528-53caecbdf5a5"),
                },
            };

            return reviews;
        }
    }
}