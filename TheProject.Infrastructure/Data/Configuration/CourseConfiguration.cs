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
                },
                new Course()
                {
                    Id = Guid.Parse("ae35af86-a051-46f0-9aef-980d4e7585ac"),
                    Title = "Sustainable Living",
                    Description = "An exploration of sustainable living practices including renewable energy, green building, and sustainable agriculture.",
                    ImageUrl = "https://media.restless.co.uk/uploads/2021/04/13_tips_for_sustainable_living.jpg",
                    StartDate = new DateTime(2024, 6, 15),
                    EndDate = new DateTime(2024, 7, 15),
                    CategoryId = 5,
                    Interested = 65
                },
                new Course()
                {
                    Id = Guid.Parse("c65ee8c7-189a-4730-9171-d89324a534de"),
                    Title = "Introduction to Robotics",
                    Description = "Get hands-on experience building and programming your first robot using Arduino and Raspberry Pi.",
                    ImageUrl = "https://miro.medium.com/v2/resize:fit:960/1*o2QkJWlZWqtDa-g3luWT1Q.jpeg",
                    StartDate = new DateTime(2024, 7, 1),
                    EndDate = new DateTime(2024, 8, 1),
                    CategoryId = 6,
                    Interested = 80
                },
                new Course()
                {
                    Id = Guid.Parse("f7b36bbc-397a-411d-b15c-b51355eb4465"),
                    Title = "Spanish for Beginners",
                    Description = "Learn Spanish from scratch! Master the basics of conversation, grammar, and vocabulary with this interactive course.",
                    ImageUrl = "https://effortlessconversations.com/wp-content/uploads/2023/10/is-spanish-hard-learn-spanish-text-on-laptop-1024x683.jpg",
                    StartDate = new DateTime(2024, 7, 20),
                    EndDate = new DateTime(2024, 9, 20),
                    CategoryId = 7,
                    Interested = 95
                },
                new Course()
                {
                    Id = Guid.Parse("78a56892-9dba-42cf-9328-e2cf026a5b97"),
                    Title = "Mental Health First Aid",
                    Description = "Learn how to offer initial support to adults who are developing a mental health problem or experiencing a mental health crisis.",
                    ImageUrl = "https://addictionstraininginstitute.com/wp-content/uploads/2023/05/image-26.png",
                    StartDate = new DateTime(2024, 8, 10),
                    EndDate = new DateTime(2024, 9, 10),
                    CategoryId = 4,
                    Interested = 70
                },
                new Course()
                {
                    Id = Guid.Parse("6d38c7e6-84eb-411c-a528-53caecbdf5a5"),
                    Title = "Creative Writing",
                    Description = "Unlock your creative potential and discover how to craft compelling stories with character, plot, and heart.",
                    ImageUrl = "https://www.artshub.com.au/wp-content/uploads/sites/2/2022/05/shutterstock_516275947-e1652150413730.jpg",
                    StartDate = new DateTime(2024, 9, 5),
                    EndDate = new DateTime(2024, 10, 5),
                    CategoryId = 3,
                    Interested = 85
                }
                
            };
            
            return courses;
        }
    }
}