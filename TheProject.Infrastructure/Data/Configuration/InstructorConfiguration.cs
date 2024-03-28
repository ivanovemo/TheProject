using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Infrastructure.Data.Configuration
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasData(SeedInstructor());
        }

        private List<Instructor> SeedInstructor()
        {
            var instructors = new List<Instructor>()
            {
                new Instructor
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Angelina",
                    LastName = "Jolie",
                    Bio = "Expert in full stack development with over 10 years of experience.",
                    Photo = "https://i.pinimg.com/736x/b7/5b/49/b75b49e64989d5b5944c80f302228e2e.jpg",
                    CourseId = Guid.Parse("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab")
                },
                new Instructor
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Scarlett",
                    LastName = "Johansson",
                    Bio = "Data scientist specializing in machine learning and data visualization with over 8 years of experience.",
                    Photo = "https://englishtribuneimages.blob.core.windows.net/gallary-content/2023/4/2023_4$largeimg_1660471345.jpg",
                    CourseId = Guid.Parse("6663d89a-3f07-4bea-b4f4-dc8b47efe599")
                },
                new Instructor
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jennifer",
                    LastName = "Aniston",
                    Bio = "Digital marketing guru with a focus on SEO and social media strategy.",
                    Photo = "https://parade.com/.image/c_limit%2Ccs_srgb%2Cq_auto:good%2Cw_700/MTkwNTgxMDQyODUzMTkyODI5/jennifer-aniston-through-the-years.webp",
                    CourseId = Guid.Parse("412588b2-b00f-49dc-b261-04b65edfd9f3")
                },
                new Instructor
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Margot",
                    LastName = "Robbie",
                    Bio = "Renowned graphic designer with a passion for typography and brand identity.",
                    Photo = "https://media.vanityfair.com/photos/636bc27c672701552ac8f48b/master/w_1600,c_limit/1222_Margot_Robbie_embed02.jpg",
                    CourseId = Guid.Parse("557a4fcd-1f84-4487-a7bd-8240327c976b")
                },
                new Instructor
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Emma",
                    LastName = "Watson",
                    Bio = "Project management professional with extensive experience preparing candidates for the PMP® certification.",
                    Photo = "https://image.tmdb.org/t/p/original/A14lLCZYDhfYdBa0fFRpwMDiwRN.jpg",
                    CourseId = Guid.Parse("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f")
                }
            };

            return instructors;
        }
    }
}