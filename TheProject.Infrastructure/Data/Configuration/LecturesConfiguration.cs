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
                    Title = "Setting Up Your Development Environment",
                    Description = "Getting started with Node.js, Express, and MongoDB. Installation and environment setup for full stack development.",
                    StartDate = new DateTime(2024, 1, 12, 10, 0, 0),
                    Duration = 120,
                    CourseId = Guid.Parse("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Building Your First React Application",
                    Description = "Introduction to React and its core principles. Building a simple application to understand components, state, and props.",
                    StartDate = new DateTime(2024, 1, 19, 10, 0, 0),
                    Duration = 180,
                    CourseId = Guid.Parse("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Connecting Frontend with Backend",
                    Description = "Creating a seamless connection between React and Node.js. Understanding REST APIs and integrating MongoDB for data storage.",
                    StartDate = new DateTime(2024, 1, 26, 10, 0, 0),
                    Duration = 150,
                    CourseId = Guid.Parse("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Python Programming for Data Science",
                    Description = "An introduction to Python for data manipulation and analysis. Covering NumPy, pandas, and matplotlib libraries.",
                    StartDate = new DateTime(2024, 2, 18, 10, 0, 0),
                    Duration = 90,
                    CourseId = Guid.Parse("6663d89a-3f07-4bea-b4f4-dc8b47efe599")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Machine Learning Models with Scikit-learn",
                    Description = "Exploring linear regression, logistic regression, and clustering techniques using the Scikit-learn library.",
                    StartDate = new DateTime(2024, 2, 25, 10, 0, 0),
                    Duration = 120,
                    CourseId = Guid.Parse("6663d89a-3f07-4bea-b4f4-dc8b47efe599")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Deep Learning Introduction with TensorFlow",
                    Description = "An overview of neural networks and deep learning. Implementing a basic neural network using TensorFlow.",
                    StartDate = new DateTime(2024, 3, 4, 10, 0, 0),
                    Duration = 180,
                    CourseId = Guid.Parse("6663d89a-3f07-4bea-b4f4-dc8b47efe599")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Understanding SEO",
                    Description = "Diving deep into the world of search engine optimization, understanding keywords, and optimizing your website for Google.",
                    StartDate = new DateTime(2024, 3, 23, 10, 0, 0),
                    Duration = 100,
                    CourseId = Guid.Parse("412588b2-b00f-49dc-b261-04b65edfd9f3")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Effective PPC Campaigns",
                    Description = "Creating and managing pay-per-click campaigns on Google Ads and social media platforms.",
                    StartDate = new DateTime(2024, 3, 30, 10, 0, 0),
                    Duration = 120,
                    CourseId = Guid.Parse("412588b2-b00f-49dc-b261-04b65edfd9f3")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Social Media Marketing and Branding",
                    Description = "Leveraging social media platforms to enhance brand visibility and engagement. Strategies for content creation and distribution.",
                    StartDate = new DateTime(2024, 4, 6, 10, 0, 0),
                    Duration = 90,
                    CourseId = Guid.Parse("412588b2-b00f-49dc-b261-04b65edfd9f3")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Basics of Design: Color Theory and Typography",
                    Description = "An exploration of color psychology, color palettes, and the importance of typography in design.",
                    StartDate = new DateTime(2024, 4, 28, 10, 0, 0),
                    Duration = 110,
                    CourseId = Guid.Parse("557a4fcd-1f84-4487-a7bd-8240327c976b")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Adobe Photoshop Fundamentals",
                    Description = "Mastering the basics of Adobe Photoshop for photo editing and graphic creation.",
                    StartDate = new DateTime(2024, 5, 5, 10, 0, 0),
                    Duration = 180,
                    CourseId = Guid.Parse("557a4fcd-1f84-4487-a7bd-8240327c976b")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Creating Effective Visuals for Web and Print",
                    Description = "Designing impactful visuals for websites, social media, and printed materials.",
                    StartDate = new DateTime(2024, 5, 12, 10, 0, 0),
                    Duration = 140,
                    CourseId = Guid.Parse("557a4fcd-1f84-4487-a7bd-8240327c976b")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Introduction to Project Management Framework",
                    Description = "Understanding the PMBOK framework and the process groups and knowledge areas of project management.",
                    StartDate = new DateTime(2024, 6, 2, 10, 0, 0),
                    Duration = 120,
                    CourseId = Guid.Parse("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Risk Management and Mitigation",
                    Description = "Identifying, analyzing, and responding to project risks to minimize their impact.",
                    StartDate = new DateTime(2024, 6, 9, 10, 0, 0),
                    Duration = 90,
                    CourseId = Guid.Parse("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Project Scheduling and Time Management",
                    Description = "Techniques for creating realistic project schedules and ensuring timely project delivery.",
                    StartDate = new DateTime(2024, 6, 16, 10, 0, 0),
                    Duration = 150,
                    CourseId = Guid.Parse("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Renewable Energy Basics",
                    Description = "An introduction to the different types of renewable energy sources and their impact on sustainable living.",
                    StartDate = new DateTime(2024, 6, 20, 10, 0, 0),
                    Duration = 120,
                    CourseId = Guid.Parse("ae35af86-a051-46f0-9aef-980d4e7585ac")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Green Building Design",
                    Description = "Exploring the principles of green building and sustainable design in modern architecture.",
                    StartDate = new DateTime(2024, 6, 27, 10, 0, 0),
                    Duration = 90,
                    CourseId = Guid.Parse("ae35af86-a051-46f0-9aef-980d4e7585ac")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Sustainable Agriculture Techniques",
                    Description = "Understanding sustainable farming practices and how they contribute to food security and environmental health.",
                    StartDate = new DateTime(2024, 7, 4, 10, 0, 0),
                    Duration = 105,
                    CourseId = Guid.Parse("ae35af86-a051-46f0-9aef-980d4e7585ac")
                },
                
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Building Your First Robot",
                    Description = "Step-by-step guidance on creating a simple robot, focusing on the basics of mechanical design and programming.",
                    StartDate = new DateTime(2024, 7, 10, 10, 0, 0),
                    Duration = 180,
                    CourseId = Guid.Parse("c65ee8c7-189a-4730-9171-d89324a534de")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Arduino Programming Basics",
                    Description = "Introduction to programming with Arduino, including sensor integration and basic robotics control.",
                    StartDate = new DateTime(2024, 7, 17, 10, 0, 0),
                    Duration = 90,
                    CourseId = Guid.Parse("c65ee8c7-189a-4730-9171-d89324a534de")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Advanced Robotics with Raspberry Pi",
                    Description = "Exploring more complex robotics projects using Raspberry Pi, focusing on IoT applications.",
                    StartDate = new DateTime(2024, 7, 24, 10, 0, 0),
                    Duration = 120,
                    CourseId = Guid.Parse("c65ee8c7-189a-4730-9171-d89324a534de")
                },
                
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Basic Spanish Conversation",
                    Description = "Learning common phrases and expressions to start speaking Spanish in daily situations.",
                    StartDate = new DateTime(2024, 7, 30, 10, 0, 0),
                    Duration = 90,
                    CourseId = Guid.Parse("f7b36bbc-397a-411d-b15c-b51355eb4465")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Grammar Essentials",
                    Description = "Covering the foundational grammar needed to build sentences and communicate effectively in Spanish.",
                    StartDate = new DateTime(2024, 8, 6, 10, 0, 0),
                    Duration = 75,
                    CourseId = Guid.Parse("f7b36bbc-397a-411d-b15c-b51355eb4465")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Spanish Culture and Expressions",
                    Description = "Understanding the cultural nuances and expressions that are unique to the Spanish language.",
                    StartDate = new DateTime(2024, 8, 13, 10, 0, 0),
                    Duration = 60,
                    CourseId = Guid.Parse("f7b36bbc-397a-411d-b15c-b51355eb4465")
                },
                
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Understanding Mental Health",
                    Description = "An overview of mental health, including common conditions and the importance of mental wellbeing.",
                    StartDate = new DateTime(2024, 8, 20, 10, 0, 0),
                    Duration = 90,
                    CourseId = Guid.Parse("78a56892-9dba-42cf-9328-e2cf026a5b97")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Crisis Intervention Strategies",
                    Description = "Techniques for providing immediate, short-term help to individuals experiencing a mental health crisis.",
                    StartDate = new DateTime(2024, 8, 27, 10, 0, 0),
                    Duration = 120,
                    CourseId = Guid.Parse("78a56892-9dba-42cf-9328-e2cf026a5b97")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Promoting Mental Health Awareness",
                    Description = "Strategies for raising awareness and reducing stigma associated with mental health issues.",
                    StartDate = new DateTime(2024, 9, 3, 10, 0, 0),
                    Duration = 75,
                    CourseId = Guid.Parse("78a56892-9dba-42cf-9328-e2cf026a5b97")
                },
                
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Fundamentals of Creative Writing",
                    Description = "Exploring the key elements of creative writing, including narrative structure, character development, and voice.",
                    StartDate = new DateTime(2024, 9, 10, 10, 0, 0),
                    Duration = 120,
                    CourseId = Guid.Parse("6d38c7e6-84eb-411c-a528-53caecbdf5a5")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "Crafting Compelling Characters",
                    Description = "Techniques for creating complex, believable characters that engage readers.",
                    StartDate = new DateTime(2024, 9, 17, 10, 0, 0),
                    Duration = 90,
                    CourseId = Guid.Parse("6d38c7e6-84eb-411c-a528-53caecbdf5a5")
                },
                new Lecture
                {
                    Id = Guid.NewGuid(),
                    Title = "The Art of Storytelling",
                    Description = "Mastering the art of storytelling, focusing on plot development and the emotional journey of the characters.",
                    StartDate = new DateTime(2024, 9, 24, 10, 0, 0),
                    Duration = 105,
                    CourseId = Guid.Parse("6d38c7e6-84eb-411c-a528-53caecbdf5a5")
                },

            };

            return lectures;
        }
    }
}