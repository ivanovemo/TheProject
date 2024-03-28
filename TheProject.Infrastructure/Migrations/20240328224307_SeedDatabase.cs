using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheProject.Infrastructure.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Reviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0afe2b81-40c4-4ae7-9ebd-0ccaa1b0b64f", 0, "83052185-75c0-43c7-b9ea-4cc61bed4434", "guest1@gmail.com", false, false, null, "GUEST1@GMAIL.COM", "guest1", "AQAAAAEAACcQAAAAELgVRHyj1UerriLx7E4l6yJv/ODJ/6ybVaZ71V4N4wSiA19dWNTrCnLiFq7aswGEfw==", null, false, "47ff3e18-11a6-4cbf-926f-9a0f987b82e4", false, "guest1" },
                    { "2d64777e-f833-4eca-803b-8eb1b0670a5c", 0, "70e5d5fd-1c13-40ae-abd7-b826f29a03fb", "admin1@gmail.com", false, false, null, "ADMIN1@GMAIL.COM", "admin1", "AQAAAAEAACcQAAAAEJnMAihpF6mrBaqd15HGBu62bdHp0niA7x1WpeYJ+nTkZNTaw/VgyR+OBD1PkSk/ug==", null, false, "4054a77f-53ec-4829-9b53-69cb38bc72e4", false, "admin1" },
                    { "6b79f761-5a4e-4457-a53b-cfc7c36ab084", 0, "3ad3fd9b-4c77-4cdc-928a-ae8e9e24fcf8", "user1@gmail.com", false, false, null, "USER1@GMAIL.COM", "user1", "AQAAAAEAACcQAAAAENNVhxWKXB/s2pm5ZmZdqolF5CZyYQSjb8C40Pko6ZV5tqBwN8yuRaQbndLDFDY3aw==", null, false, "264cad39-bb5b-4b6f-afb0-871cdbef9645", false, "user1" },
                    { "6c3438cd-8332-4e95-9a5e-adb64ec972d6", 0, "6bae1be2-f14f-446a-9c6d-3faea06127fb", "user2@gmail.com", false, false, null, "USER2@GMAIL.COM", "user2", "AQAAAAEAACcQAAAAEOPjot7rbkQfqSBJtXjpOtEsYLMMRZrBmO418W2Cd9q5HHj6YilwzP4IgVCImi4hFw==", null, false, "77fb9c30-22e8-40dc-8543-a0943e2f6709", false, "user2" },
                    { "addd0c13-6a3f-4706-afc8-219f5e89badd", 0, "9bdd2bc8-58cb-4f8f-964b-d6812baaeaf3", "user3@gmail.com", false, false, null, "USER3@GMAIL.COM", "user3", "AQAAAAEAACcQAAAAEFWWqE+7zBThjwUXHXlMDSCU9adUYgPnzHj5ExSoBkpUi6B63/15nmm2LmlHhS3rVQ==", null, false, "30421e61-085a-478d-950e-da48b6fbd6f4", false, "user3" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Technology and Computer Science" },
                    { 2, "Business and Entrepreneurship" },
                    { 3, "Creative Arts and Design" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "EndDate", "ImageUrl", "Interested", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), 2, "Master digital marketing tools and strategies, including SEO, PPC, social media, and content marketing.", new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.redbricksmedia.com/wp-content/uploads/2023/04/What-are-the-Advantages-of-Digital-Marketing.jpg", 90, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Digital Marketing Essentials" },
                    { new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), 3, "Explore the fundamentals of graphic design, including layout, composition, typography, and color theory.", null, "https://i.ytimg.com/vi/YqQx75OPRa0/maxresdefault.jpg", 110, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to Graphic Design" },
                    { new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), 1, "Dive into data science and machine learning with Python, exploring data visualization, machine learning models, and more.", null, "https://media.geeksforgeeks.org/wp-content/uploads/20210629202956/DataV.png", 150, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Science and Machine Learning" },
                    { new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), 1, "Learn to build scalable web applications using React, Node.js, Express, and MongoDB.", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://img-b.udemycdn.com/course/750x422/2715276_2923_2.jpg", 120, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Full Stack Web Development" },
                    { new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), 2, "Prepare for the PMP certification exam with this comprehensive course covering project management best practices.", new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://play-lh.googleusercontent.com/KO4qR1Yik54zkBEWKoVqbUtJqOAw2w6loHapeAaacDeBpy9lU7hM1fpNU-VN4kzRwpc", 75, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project Management Professional Certification Prep" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Bio", "CourseId", "FirstName", "LastName", "Photo" },
                values: new object[,]
                {
                    { new Guid("15eddde4-7a5d-4f6e-97d7-f9378e880da7"), "Project management professional with extensive experience preparing candidates for the PMP® certification.", new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Emma", "Watson", "https://image.tmdb.org/t/p/original/A14lLCZYDhfYdBa0fFRpwMDiwRN.jpg" },
                    { new Guid("9eda2f0b-b708-4038-8f38-245444f5c9bf"), "Expert in full stack development with over 10 years of experience.", new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Angelina", "Jolie", "https://i.pinimg.com/736x/b7/5b/49/b75b49e64989d5b5944c80f302228e2e.jpg" },
                    { new Guid("bd6cf82d-a7b0-4b32-a660-a99f905e6a0a"), "Data scientist specializing in machine learning and data visualization with over 8 years of experience.", new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Scarlett", "Johansson", "https://englishtribuneimages.blob.core.windows.net/gallary-content/2023/4/2023_4$largeimg_1660471345.jpg" },
                    { new Guid("d1ce4566-c33c-4534-977b-e964e6244f4b"), "Digital marketing guru with a focus on SEO and social media strategy.", new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Jennifer", "Aniston", "https://parade.com/.image/c_limit%2Ccs_srgb%2Cq_auto:good%2Cw_700/MTkwNTgxMDQyODUzMTkyODI5/jennifer-aniston-through-the-years.webp" },
                    { new Guid("d8736e7c-a217-4aae-92d9-f7c1a1ffdc76"), "Renowned graphic designer with a passion for typography and brand identity.", new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Margot", "Robbie", "https://media.vanityfair.com/photos/636bc27c672701552ac8f48b/master/w_1600,c_limit/1222_Margot_Robbie_embed02.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "Id", "CourseId", "Description", "Duration", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("1b55d95c-e3fb-42a5-b493-8dc990ae9778"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "A deep dive into the core principles of graphic design, focusing on composition and layout.", new TimeSpan(0, 3, 0, 0, 0), new DateTime(2024, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Design Principles: Composition and Layout" },
                    { new Guid("2e683944-e760-4a78-8841-35bfe9ea0ba7"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Covering the fundamental concepts and terminologies of project management.", new TimeSpan(0, 2, 0, 0, 0), new DateTime(2024, 6, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "Project Management Basics" },
                    { new Guid("33b60157-9b69-4dbd-89aa-8c68f7fe34a7"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Understanding the basics of web development with HTML and CSS.", new TimeSpan(0, 2, 30, 0, 0), new DateTime(2024, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to HTML and CSS" },
                    { new Guid("377bad54-86b4-4cab-9bca-ed5fd94740e7"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Learn the basics of Search Engine Optimization to increase your website visibility.", new TimeSpan(0, 1, 15, 0, 0), new DateTime(2024, 3, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "SEO Fundamentals" },
                    { new Guid("4da4bff7-6f94-498d-84f2-100fa3c91d36"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Strategies and tips for tackling the PMP certification exam.", new TimeSpan(0, 2, 0, 0, 0), new DateTime(2024, 6, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Preparing for the PMP Exam" },
                    { new Guid("73472ee4-a2a6-456c-9535-00a3ce027c40"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Analyzing data sets to summarize their main characteristics.", new TimeSpan(0, 2, 0, 0, 0), new DateTime(2024, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "Exploratory Data Analysis" },
                    { new Guid("8ebcefae-69f7-46d7-8f88-981e381f5850"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Interactive web pages with JavaScript.", new TimeSpan(0, 3, 0, 0, 0), new DateTime(2024, 1, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "JavaScript and the Web" },
                    { new Guid("ba0ba8c2-8d6f-4127-a070-9f2baa1327e7"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Introduction to Python and its libraries for data science.", new TimeSpan(0, 1, 30, 0, 0), new DateTime(2024, 2, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), "Python for Data Science" },
                    { new Guid("cb915ba6-4f59-4e01-a4ed-8002d0ca83e6"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Exploring the role of typography in graphic design and how to use it effectively.", new TimeSpan(0, 5, 0, 0, 0), new DateTime(2024, 5, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "Typography in Design" },
                    { new Guid("ce51626c-b74c-44ef-a73b-8fc494905789"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Effective strategies for engaging with your audience on social media platforms.", new TimeSpan(0, 1, 0, 0, 0), new DateTime(2024, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Social Media Marketing Strategies" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CourseId", "Description", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("141bee25-c82f-4792-9682-f98421473072"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Great insights into digital marketing strategies. Useful for all levels.", 7, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("482c02ef-7903-4d8e-8779-1abfef65f7b8"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Excellent course on data science. Highly recommend for beginners and intermediates.", 9, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("557e40f9-9962-4b60-bb63-28218fe0f22f"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "This course exceeded my expectations! The content was clear, and the projects were both challenging and rewarding.", 10, "addd0c13-6a3f-4706-afc8-219f5e89badd" },
                    { new Guid("8a81b013-16b0-4534-9250-4faa26f79d41"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "The PMP prep course was detailed and well-structured. It helped me pass the exam on the first try.", 8, "addd0c13-6a3f-4706-afc8-219f5e89badd" },
                    { new Guid("cb0485b4-1710-42d6-a0f4-980bee02e48b"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "A comprehensive course that offers deep insights into full stack development.", 8, "6b79f761-5a4e-4457-a53b-cfc7c36ab084" },
                    { new Guid("d6588c27-e694-4061-894d-eb5c96718e8f"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Loved the practical approach to graphic design principles. The examples were very helpful.", 6, "addd0c13-6a3f-4706-afc8-219f5e89badd" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0afe2b81-40c4-4ae7-9ebd-0ccaa1b0b64f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d64777e-f833-4eca-803b-8eb1b0670a5c");

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("15eddde4-7a5d-4f6e-97d7-f9378e880da7"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("9eda2f0b-b708-4038-8f38-245444f5c9bf"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("bd6cf82d-a7b0-4b32-a660-a99f905e6a0a"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("d1ce4566-c33c-4534-977b-e964e6244f4b"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("d8736e7c-a217-4aae-92d9-f7c1a1ffdc76"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("1b55d95c-e3fb-42a5-b493-8dc990ae9778"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("2e683944-e760-4a78-8841-35bfe9ea0ba7"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("33b60157-9b69-4dbd-89aa-8c68f7fe34a7"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("377bad54-86b4-4cab-9bca-ed5fd94740e7"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("4da4bff7-6f94-498d-84f2-100fa3c91d36"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("73472ee4-a2a6-456c-9535-00a3ce027c40"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("8ebcefae-69f7-46d7-8f88-981e381f5850"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("ba0ba8c2-8d6f-4127-a070-9f2baa1327e7"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("cb915ba6-4f59-4e01-a4ed-8002d0ca83e6"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("ce51626c-b74c-44ef-a73b-8fc494905789"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("141bee25-c82f-4792-9682-f98421473072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("482c02ef-7903-4d8e-8779-1abfef65f7b8"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("557e40f9-9962-4b60-bb63-28218fe0f22f"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("8a81b013-16b0-4534-9250-4faa26f79d41"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("cb0485b4-1710-42d6-a0f4-980bee02e48b"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("d6588c27-e694-4061-894d-eb5c96718e8f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b79f761-5a4e-4457-a53b-cfc7c36ab084");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c3438cd-8332-4e95-9a5e-adb64ec972d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "addd0c13-6a3f-4706-afc8-219f5e89badd");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Reviews",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);
        }
    }
}
