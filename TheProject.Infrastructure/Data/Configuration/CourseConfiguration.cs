using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Infrastructure.Data.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(SeedCourses());
        }

        private List<Course> SeedCourses()
        {
            var courses = new List<Course>()
            {
                new Course()
                {
                    Id = Guid.Parse("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"),
                    Title = "Full Stack Web Development",
                    Description = "Learn to build scalable web applications using React, Node.js, Express, and MongoDB.",
                    ImageUrl = "https://img-b.udemycdn.com/course/750x422/2715276_2923_2.jpg",
                    StartDate = new DateTime(2024, 1, 10),
                    EndDate = new DateTime(2024, 2, 10),
                    CategoryId = 1,
                    Interested = 120
                },
                new Course
                {
                    Id = Guid.Parse("6663d89a-3f07-4bea-b4f4-dc8b47efe599"),
                    Title = "Data Science and Machine Learning",
                    Description = "Dive into data science and machine learning with Python, exploring data visualization, machine learning models, and more.",
                    ImageUrl = "https://media.geeksforgeeks.org/wp-content/uploads/20210629202956/DataV.png",
                    StartDate = new DateTime(2024, 2, 15),
                    EndDate= new DateTime(2024,4,15),
                    CategoryId = 1,
                    Interested = 150
                },
                new Course
                {
                    Id = Guid.Parse("412588b2-b00f-49dc-b261-04b65edfd9f3"),
                    Title = "Digital Marketing Essentials",
                    Description = "Master digital marketing tools and strategies, including SEO, PPC, social media, and content marketing.",
                    ImageUrl = "https://www.redbricksmedia.com/wp-content/uploads/2023/04/What-are-the-Advantages-of-Digital-Marketing.jpg",
                    StartDate = new DateTime(2024, 3, 20),
                    EndDate = new DateTime(2024, 5, 20),
                    CategoryId = 2,
                    Interested = 90
                },
                new Course
                {
                    Id = Guid.Parse("557a4fcd-1f84-4487-a7bd-8240327c976b"),
                    Title = "Introduction to Graphic Design",
                    Description = "Explore the fundamentals of graphic design, including layout, composition, typography, and color theory.",
                    ImageUrl = "https://i.ytimg.com/vi/YqQx75OPRa0/maxresdefault.jpg",
                    StartDate = new DateTime(2024, 4, 25),
                    EndDate= new DateTime(2024,6,1),
                    CategoryId = 3,
                    Interested = 110
                },
                new Course
                {
                    Id = Guid.Parse("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"),
                    Title = "Project Management Professional Certification Prep",
                    Description = "Prepare for the PMP certification exam with this comprehensive course covering project management best practices.",
                    ImageUrl = "https://play-lh.googleusercontent.com/KO4qR1Yik54zkBEWKoVqbUtJqOAw2w6loHapeAaacDeBpy9lU7hM1fpNU-VN4kzRwpc",
                    StartDate = new DateTime(2024, 5, 30),
                    EndDate = new DateTime(2024, 8, 30),
                    CategoryId = 2,
                    Interested = 75
                }
            };

            return courses;
        }
    }
}