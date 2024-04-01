using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Infrastructure.Data.Configuration
{
    public class LecturesConfiguration : IEntityTypeConfiguration<Lecture>
    {
        public void Configure(EntityTypeBuilder<Lecture> builder)
        {
            builder.HasData(SeedLectures());
        }

        private List<Lecture> SeedLectures()
        {
            var lectures = new List<Lecture>()
            {
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Introduction to HTML and CSS",
                    Description = "Understanding the basics of web development with HTML and CSS.",
                    StartDate = new DateTime(2024, 1, 15, 10, 0, 0),
                    Duration = TimeSpan.FromMinutes(150),
                    CourseId = Guid.Parse("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "JavaScript and the Web",
                    Description = "Interactive web pages with JavaScript.",
                    StartDate = new DateTime(2024, 1, 22, 10, 0, 0),
                    Duration = TimeSpan.FromMinutes(180),
                    CourseId = Guid.Parse("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab")
                },

                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Python for Data Science",
                    Description = "Introduction to Python and its libraries for data science.",
                    StartDate = new DateTime(2024, 2, 20, 10, 0, 0),
                    Duration = TimeSpan.FromMinutes(90),
                    CourseId = Guid.Parse("6663d89a-3f07-4bea-b4f4-dc8b47efe599")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Exploratory Data Analysis",
                    Description = "Analyzing data sets to summarize their main characteristics.",
                    StartDate = new DateTime(2024, 2, 27, 10, 0, 0),
                    Duration = TimeSpan.FromMinutes(120),
                    CourseId = Guid.Parse("6663d89a-3f07-4bea-b4f4-dc8b47efe599")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "SEO Fundamentals",
                    Description = "Learn the basics of Search Engine Optimization to increase your website visibility.",
                    StartDate = new DateTime(2024, 3, 25, 10, 0, 0),
                    Duration = TimeSpan.FromMinutes(75),
                    CourseId = Guid.Parse("412588b2-b00f-49dc-b261-04b65edfd9f3")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Social Media Marketing Strategies",
                    Description = "Effective strategies for engaging with your audience on social media platforms.",
                    StartDate = new DateTime(2024, 4, 1, 10, 0, 0),
                    Duration = TimeSpan.FromMinutes(60),
                    CourseId = Guid.Parse("412588b2-b00f-49dc-b261-04b65edfd9f3")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Design Principles: Composition and Layout",
                    Description = "A deep dive into the core principles of graphic design, focusing on composition and layout.",
                    StartDate = new DateTime(2024, 5, 1, 10, 0, 0),
                    Duration = TimeSpan.FromMinutes(180),
                    CourseId = Guid.Parse("557a4fcd-1f84-4487-a7bd-8240327c976b")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Typography in Design",
                    Description = "Exploring the role of typography in graphic design and how to use it effectively.",
                    StartDate = new DateTime(2024, 5, 8, 10, 0, 0),
                    Duration = TimeSpan.FromMinutes(300),
                    CourseId = Guid.Parse("557a4fcd-1f84-4487-a7bd-8240327c976b")
                },
                
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Project Management Basics",
                    Description = "Covering the fundamental concepts and terminologies of project management.",
                    StartDate = new DateTime(2024, 6, 5, 10, 0, 0),
                    Duration = TimeSpan.FromMinutes(120),
                    CourseId = Guid.Parse("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Preparing for the PMP Exam",
                    Description = "Strategies and tips for tackling the PMP certification exam.",
                    StartDate = new DateTime(2024, 6, 12, 10, 0, 0),
                    Duration = TimeSpan.FromMinutes(120),
                    CourseId = Guid.Parse("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f")
                }
            };

            return lectures;
        }
    }
}