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

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                    { "0afe2b81-40c4-4ae7-9ebd-0ccaa1b0b64f", 0, "9f50ea17-1fd9-477d-a90f-39a1e0378e25", "guest1@gmail.com", false, false, null, "GUEST1@GMAIL.COM", "guest1", "AQAAAAEAACcQAAAAEDXuDuFbY5HRReGHMqpZiBUk/inINj/ssZKMnjZeyaOsAd16ukhjyKUeGT1csN/2pA==", null, false, "63ac2c0d-1b91-49d8-8a41-d7b101d91040", false, "guest1" },
                    { "2d64777e-f833-4eca-803b-8eb1b0670a5c", 0, "75b882d4-1035-4a48-b5c1-3682b8084373", "admin1@gmail.com", false, false, null, "ADMIN1@GMAIL.COM", "admin1", "AQAAAAEAACcQAAAAEJy1vXz39LjdeqsNJUXxgyJeTo0LTbniyGpt402aA84ZTVQ+xPrdMLFD1Vatr8Aeog==", null, false, "cbdf89f5-60b4-4e26-a448-d24308c46abc", false, "admin1" },
                    { "6b79f761-5a4e-4457-a53b-cfc7c36ab084", 0, "35f710df-e7ba-432d-a41e-9b27ccfc0fed", "user1@gmail.com", false, false, null, "USER1@GMAIL.COM", "user1", "AQAAAAEAACcQAAAAEOF+gQJbeS2OOieILXAVnJHr1pYmg5WmOq2bDVGmDIivV0640I9KZf1DjQ1vsIdLHA==", null, false, "0cbd5057-4e2f-45db-af0a-f5680a073d3b", false, "user1" },
                    { "6c3438cd-8332-4e95-9a5e-adb64ec972d6", 0, "6d11eedd-66e1-46c1-98e1-033e4e7f3ecb", "user2@gmail.com", false, false, null, "USER2@GMAIL.COM", "user2", "AQAAAAEAACcQAAAAECNhJ+tqamY7MgmhFRUZNyH5ij8EpKgZAFvbCOQg9lYo6Ljm1z47Pa0wT8AzfJ+RwA==", null, false, "35600e75-4e67-489b-848c-a7b99eceb532", false, "user2" },
                    { "addd0c13-6a3f-4706-afc8-219f5e89badd", 0, "07131e56-50ad-4395-af2c-b9dc3046114b", "user3@gmail.com", false, false, null, "USER3@GMAIL.COM", "user3", "AQAAAAEAACcQAAAAEJadL++KpBx5OTB2FaujTiYfAs7pD91FxnenK3Q1BQIhQrIiXCpWIAsVuBIPcepeUQ==", null, false, "9723c8e0-588b-47d7-b1a3-941e7469efd2", false, "user3" }
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
                    { new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), 3, "Explore the fundamentals of graphic design, including layout, composition, typography, and color theory.", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://i.ytimg.com/vi/YqQx75OPRa0/maxresdefault.jpg", 110, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to Graphic Design" },
                    { new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), 1, "Dive into data science and machine learning with Python, exploring data visualization, machine learning models, and more.", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://media.geeksforgeeks.org/wp-content/uploads/20210629202956/DataV.png", 150, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Science and Machine Learning" },
                    { new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), 1, "Learn to build scalable web applications using React, Node.js, Express, and MongoDB.", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://img-b.udemycdn.com/course/750x422/2715276_2923_2.jpg", 120, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Full Stack Web Development" },
                    { new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), 2, "Prepare for the PMP certification exam with this comprehensive course covering project management best practices.", new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://play-lh.googleusercontent.com/KO4qR1Yik54zkBEWKoVqbUtJqOAw2w6loHapeAaacDeBpy9lU7hM1fpNU-VN4kzRwpc", 75, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project Management Professional Certification Prep" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Bio", "CourseId", "FirstName", "LastName", "Photo" },
                values: new object[,]
                {
                    { new Guid("0b4f1363-8c03-48dc-bd08-fad9d4cc458b"), "Expert in full stack development with over 10 years of experience.", new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Angelina", "Jolie", "https://i.pinimg.com/736x/b7/5b/49/b75b49e64989d5b5944c80f302228e2e.jpg" },
                    { new Guid("1be5e5fc-b0e4-4858-95df-27a1062ba57f"), "Project management professional with extensive experience preparing candidates for the PMP® certification.", new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Emma", "Watson", "https://image.tmdb.org/t/p/original/A14lLCZYDhfYdBa0fFRpwMDiwRN.jpg" },
                    { new Guid("538279e7-f060-422b-96ac-7fffa70832f1"), "Digital marketing guru with a focus on SEO and social media strategy.", new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Jennifer", "Aniston", "https://parade.com/.image/c_limit%2Ccs_srgb%2Cq_auto:good%2Cw_700/MTkwNTgxMDQyODUzMTkyODI5/jennifer-aniston-through-the-years.webp" },
                    { new Guid("b7a54332-4904-4806-8aab-e27c64e59b24"), "Data scientist specializing in machine learning and data visualization with over 8 years of experience.", new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Scarlett", "Johansson", "https://englishtribuneimages.blob.core.windows.net/gallary-content/2023/4/2023_4$largeimg_1660471345.jpg" },
                    { new Guid("ff1a42d7-db91-437e-bc0f-5012f9a5d68f"), "Renowned graphic designer with a passion for typography and brand identity.", new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Margot", "Robbie", "https://media.vanityfair.com/photos/636bc27c672701552ac8f48b/master/w_1600,c_limit/1222_Margot_Robbie_embed02.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "Id", "CourseId", "Description", "Duration", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0b252781-a615-4eaa-bae7-d55c78f627f2"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Effective strategies for engaging with your audience on social media platforms.", new TimeSpan(0, 1, 0, 0, 0), new DateTime(2024, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Social Media Marketing Strategies" },
                    { new Guid("0d5de950-f96f-420f-bf37-ea70344170e4"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Exploring the role of typography in graphic design and how to use it effectively.", new TimeSpan(0, 5, 0, 0, 0), new DateTime(2024, 5, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "Typography in Design" },
                    { new Guid("14b4501c-6a83-4336-8f7e-0b546869d2c1"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Covering the fundamental concepts and terminologies of project management.", new TimeSpan(0, 2, 0, 0, 0), new DateTime(2024, 6, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "Project Management Basics" },
                    { new Guid("3ad40bba-028b-4c83-b7c9-6822bc54964e"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Learn the basics of Search Engine Optimization to increase your website visibility.", new TimeSpan(0, 1, 15, 0, 0), new DateTime(2024, 3, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "SEO Fundamentals" },
                    { new Guid("4d522ed8-8a34-4b60-9428-10d54c8d6a41"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Analyzing data sets to summarize their main characteristics.", new TimeSpan(0, 2, 0, 0, 0), new DateTime(2024, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "Exploratory Data Analysis" },
                    { new Guid("56b480ea-be5b-4bdf-b8b6-6c2fa1c3d96b"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Strategies and tips for tackling the PMP certification exam.", new TimeSpan(0, 2, 0, 0, 0), new DateTime(2024, 6, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Preparing for the PMP Exam" },
                    { new Guid("7466e5fb-055a-4ad5-aa11-ec006c1b460c"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Introduction to Python and its libraries for data science.", new TimeSpan(0, 1, 30, 0, 0), new DateTime(2024, 2, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), "Python for Data Science" },
                    { new Guid("92a2077b-9b32-494e-9e7d-f7d01dca7d49"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "A deep dive into the core principles of graphic design, focusing on composition and layout.", new TimeSpan(0, 3, 0, 0, 0), new DateTime(2024, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Design Principles: Composition and Layout" },
                    { new Guid("d9ef67c8-b780-4837-b54a-70f722a28aec"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Understanding the basics of web development with HTML and CSS.", new TimeSpan(0, 2, 30, 0, 0), new DateTime(2024, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to HTML and CSS" },
                    { new Guid("fcf037a7-61a8-4113-b6e7-1d92bad5e3f3"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Interactive web pages with JavaScript.", new TimeSpan(0, 3, 0, 0, 0), new DateTime(2024, 1, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "JavaScript and the Web" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CourseId", "Description", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("33fd01ad-45d2-4d19-9c93-af5dda76377b"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "This course exceeded my expectations! The content was clear, and the projects were both challenging and rewarding.", 10, "addd0c13-6a3f-4706-afc8-219f5e89badd" },
                    { new Guid("37fcca74-8e2f-40b5-8951-b341f5e1f268"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "The PMP prep course was detailed and well-structured. It helped me pass the exam on the first try.", 8, "addd0c13-6a3f-4706-afc8-219f5e89badd" },
                    { new Guid("529b45df-6480-4740-8781-080e1ab3fe10"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "A comprehensive course that offers deep insights into full stack development.", 8, "6b79f761-5a4e-4457-a53b-cfc7c36ab084" },
                    { new Guid("67f65074-22ed-4b14-a668-e8a3d917e892"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Excellent course on data science. Highly recommend for beginners and intermediates.", 9, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("836384e4-368d-4c34-8cec-7cad94caa3ac"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Great insights into digital marketing strategies. Useful for all levels.", 7, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("f1f8bfa7-35fd-48a9-bc61-a9f0d9ff9ed5"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Loved the practical approach to graphic design principles. The examples were very helpful.", 6, "addd0c13-6a3f-4706-afc8-219f5e89badd" }
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
                keyValue: new Guid("0b4f1363-8c03-48dc-bd08-fad9d4cc458b"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("1be5e5fc-b0e4-4858-95df-27a1062ba57f"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("538279e7-f060-422b-96ac-7fffa70832f1"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("b7a54332-4904-4806-8aab-e27c64e59b24"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("ff1a42d7-db91-437e-bc0f-5012f9a5d68f"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("0b252781-a615-4eaa-bae7-d55c78f627f2"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("0d5de950-f96f-420f-bf37-ea70344170e4"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("14b4501c-6a83-4336-8f7e-0b546869d2c1"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("3ad40bba-028b-4c83-b7c9-6822bc54964e"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("4d522ed8-8a34-4b60-9428-10d54c8d6a41"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("56b480ea-be5b-4bdf-b8b6-6c2fa1c3d96b"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("7466e5fb-055a-4ad5-aa11-ec006c1b460c"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("92a2077b-9b32-494e-9e7d-f7d01dca7d49"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("d9ef67c8-b780-4837-b54a-70f722a28aec"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("fcf037a7-61a8-4113-b6e7-1d92bad5e3f3"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("33fd01ad-45d2-4d19-9c93-af5dda76377b"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("37fcca74-8e2f-40b5-8951-b341f5e1f268"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("529b45df-6480-4740-8781-080e1ab3fe10"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("67f65074-22ed-4b14-a668-e8a3d917e892"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("836384e4-368d-4c34-8cec-7cad94caa3ac"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("f1f8bfa7-35fd-48a9-bc61-a9f0d9ff9ed5"));

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
