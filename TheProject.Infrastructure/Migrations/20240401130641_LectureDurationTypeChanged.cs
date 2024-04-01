using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheProject.Infrastructure.Migrations
{
    public partial class LectureDurationTypeChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TempDuration",
                table: "Lectures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.Sql(
                "UPDATE Lectures SET TempDuration = DATEDIFF(MINUTE, '00:00:00', CAST(Duration AS TIME))");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Lectures");

            migrationBuilder.RenameColumn(
                name: "TempDuration",
                table: "Lectures",
                newName: "Duration");

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

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Lectures",
                type: "int",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0afe2b81-40c4-4ae7-9ebd-0ccaa1b0b64f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d277ad44-295c-4714-a916-18918387ef3a", "AQAAAAEAACcQAAAAEKdlr5eMaoT+DSeYnnVN3/bXWfGViJbKXJwXOpuxGP1vE5+bXVrg1dNO5tJDLCrvxA==", "1c8ea878-ddd6-4e6f-86e7-3f7fbf602970" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97ea2eb7-c7f8-4c64-b68c-853c2b9c6125", "AQAAAAEAACcQAAAAEK8yOClGYeFN6LvE3+zdPfxnjyP7rej9BfCq6utQaVEZrwcf1ily6SYcw/fpkPTfIg==", "66311510-4ae6-4821-b3ce-11c6dd193973" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b79f761-5a4e-4457-a53b-cfc7c36ab084",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4152784f-7f70-434f-a7be-bf1de1117962", "AQAAAAEAACcQAAAAEHsr13WvNEMgnzwkP8pcBwsrrs0xhZBaGIugX+XxePW0gYQ9WbMJEIpg2lHZXet8gw==", "e16c0e5c-6fd7-4371-a7ee-197805e4e8f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5ce7809-95e5-4580-9855-f5af58cc6a0d", "AQAAAAEAACcQAAAAEPH0bwTNDPvFxIYTTt+/vjqb6Z4cgWeL2JKGK93Mj50dMT31JhXJG6sp/ogxOLIjoQ==", "9c010e36-9147-48d3-849f-0cc88d5c37c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "addd0c13-6a3f-4706-afc8-219f5e89badd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "534d0bef-7685-4851-9a29-bb20e6bc6389", "AQAAAAEAACcQAAAAEK5iX/FR2Glork3Sl0RuCKnxpUwPaUqx4Mu5SEIzwMRFLzmW/zW7zez9/NKKsndkAg==", "9c0a42a3-b2c8-4e6e-93e0-59102ffb4e47" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Bio", "CourseId", "FirstName", "LastName", "Photo" },
                values: new object[,]
                {
                    { new Guid("061a0852-bfe6-4bc5-8430-643d4bde544c"), "Data scientist specializing in machine learning and data visualization with over 8 years of experience.", new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Scarlett", "Johansson", "https://englishtribuneimages.blob.core.windows.net/gallary-content/2023/4/2023_4$largeimg_1660471345.jpg" },
                    { new Guid("58587d3f-7e5b-4860-9c92-8212ffff5fdc"), "Project management professional with extensive experience preparing candidates for the PMP® certification.", new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Emma", "Watson", "https://image.tmdb.org/t/p/original/A14lLCZYDhfYdBa0fFRpwMDiwRN.jpg" },
                    { new Guid("6cd58db5-501e-4575-bef0-70f9f56ef6e7"), "Expert in full stack development with over 10 years of experience.", new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Angelina", "Jolie", "https://i.pinimg.com/736x/b7/5b/49/b75b49e64989d5b5944c80f302228e2e.jpg" },
                    { new Guid("b6d6274e-f1a8-4b19-b29a-770b14197ae5"), "Renowned graphic designer with a passion for typography and brand identity.", new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Margot", "Robbie", "https://media.vanityfair.com/photos/636bc27c672701552ac8f48b/master/w_1600,c_limit/1222_Margot_Robbie_embed02.jpg" },
                    { new Guid("be090b32-27f6-4df1-a766-ea8725cb0bb1"), "Digital marketing guru with a focus on SEO and social media strategy.", new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Jennifer", "Aniston", "https://parade.com/.image/c_limit%2Ccs_srgb%2Cq_auto:good%2Cw_700/MTkwNTgxMDQyODUzMTkyODI5/jennifer-aniston-through-the-years.webp" }
                });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "Id", "CourseId", "Description", "Duration", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("1f65fb2a-76ed-49c7-88cf-7c936d6840f2"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Strategies and tips for tackling the PMP certification exam.", 220, new DateTime(2024, 6, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Preparing for the PMP Exam" },
                    { new Guid("1fb2b106-e617-40c1-ab28-22f5f5906a61"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "A deep dive into the core principles of graphic design, focusing on composition and layout.", 180, new DateTime(2024, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Design Principles: Composition and Layout" },
                    { new Guid("2dbf96e1-7c6d-42a5-afbe-f24e17144e8f"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Effective strategies for engaging with your audience on social media platforms.", 60, new DateTime(2024, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Social Media Marketing Strategies" },
                    { new Guid("2f5a81c0-21e5-4ae7-ad47-935072425d0f"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Introduction to Python and its libraries for data science.", 90, new DateTime(2024, 2, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), "Python for Data Science" },
                    { new Guid("346c6e44-2341-49ad-8ab3-b8a531e2807b"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Exploring the role of typography in graphic design and how to use it effectively.", 300, new DateTime(2024, 5, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "Typography in Design" },
                    { new Guid("5ef79023-7240-41bf-b036-7a43f1b9b63a"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Interactive web pages with JavaScript.", 180, new DateTime(2024, 1, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "JavaScript and the Web" },
                    { new Guid("6086b50c-ae42-44d8-98d1-22cad27730c8"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Learn the basics of Search Engine Optimization to increase your website visibility.", 75, new DateTime(2024, 3, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "SEO Fundamentals" },
                    { new Guid("7cb738ff-ccb5-4ffb-bb2b-9adb5e3679e5"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Covering the fundamental concepts and terminologies of project management.", 120, new DateTime(2024, 6, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "Project Management Basics" },
                    { new Guid("900aada6-56d2-41ba-98ee-5bd69c533076"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Analyzing data sets to summarize their main characteristics.", 120, new DateTime(2024, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "Exploratory Data Analysis" },
                    { new Guid("f191d5ed-6335-4b96-a2a8-cdfd2c3871b9"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Understanding the basics of web development with HTML and CSS.", 150, new DateTime(2024, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to HTML and CSS" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CourseId", "Description", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("05913ae3-ea20-45f8-a083-9065067e5e48"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Excellent course on data science. Highly recommend for beginners and intermediates.", 9, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("1a620e1c-7f3e-46da-a987-ed5c0e2ac829"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "A comprehensive course that offers deep insights into full stack development.", 8, "6b79f761-5a4e-4457-a53b-cfc7c36ab084" },
                    { new Guid("5bd12674-bd44-4b5f-b769-874dc9d21f9b"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "This course exceeded my expectations! The content was clear, and the projects were both challenging and rewarding.", 10, "addd0c13-6a3f-4706-afc8-219f5e89badd" },
                    { new Guid("c78f41e6-7ca3-48cf-b42e-95cf94ab6dc5"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Great insights into digital marketing strategies. Useful for all levels.", 7, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("db1fc26c-833d-419e-958a-b4f75cb7a6a4"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Loved the practical approach to graphic design principles. The examples were very helpful.", 6, "addd0c13-6a3f-4706-afc8-219f5e89badd" },
                    { new Guid("e73937da-6681-49e8-99a7-a487f9479159"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "The PMP prep course was detailed and well-structured. It helped me pass the exam on the first try.", 8, "addd0c13-6a3f-4706-afc8-219f5e89badd" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("061a0852-bfe6-4bc5-8430-643d4bde544c"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("58587d3f-7e5b-4860-9c92-8212ffff5fdc"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("6cd58db5-501e-4575-bef0-70f9f56ef6e7"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("b6d6274e-f1a8-4b19-b29a-770b14197ae5"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("be090b32-27f6-4df1-a766-ea8725cb0bb1"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("1f65fb2a-76ed-49c7-88cf-7c936d6840f2"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("1fb2b106-e617-40c1-ab28-22f5f5906a61"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("2dbf96e1-7c6d-42a5-afbe-f24e17144e8f"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("2f5a81c0-21e5-4ae7-ad47-935072425d0f"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("346c6e44-2341-49ad-8ab3-b8a531e2807b"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("5ef79023-7240-41bf-b036-7a43f1b9b63a"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("6086b50c-ae42-44d8-98d1-22cad27730c8"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("7cb738ff-ccb5-4ffb-bb2b-9adb5e3679e5"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("900aada6-56d2-41ba-98ee-5bd69c533076"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("f191d5ed-6335-4b96-a2a8-cdfd2c3871b9"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("05913ae3-ea20-45f8-a083-9065067e5e48"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("1a620e1c-7f3e-46da-a987-ed5c0e2ac829"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("5bd12674-bd44-4b5f-b769-874dc9d21f9b"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("c78f41e6-7ca3-48cf-b42e-95cf94ab6dc5"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("db1fc26c-833d-419e-958a-b4f75cb7a6a4"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e73937da-6681-49e8-99a7-a487f9479159"));

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duration",
                table: "Lectures",
                type: "time",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0afe2b81-40c4-4ae7-9ebd-0ccaa1b0b64f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f50ea17-1fd9-477d-a90f-39a1e0378e25", "AQAAAAEAACcQAAAAEDXuDuFbY5HRReGHMqpZiBUk/inINj/ssZKMnjZeyaOsAd16ukhjyKUeGT1csN/2pA==", "63ac2c0d-1b91-49d8-8a41-d7b101d91040" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75b882d4-1035-4a48-b5c1-3682b8084373", "AQAAAAEAACcQAAAAEJy1vXz39LjdeqsNJUXxgyJeTo0LTbniyGpt402aA84ZTVQ+xPrdMLFD1Vatr8Aeog==", "cbdf89f5-60b4-4e26-a448-d24308c46abc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b79f761-5a4e-4457-a53b-cfc7c36ab084",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35f710df-e7ba-432d-a41e-9b27ccfc0fed", "AQAAAAEAACcQAAAAEOF+gQJbeS2OOieILXAVnJHr1pYmg5WmOq2bDVGmDIivV0640I9KZf1DjQ1vsIdLHA==", "0cbd5057-4e2f-45db-af0a-f5680a073d3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d11eedd-66e1-46c1-98e1-033e4e7f3ecb", "AQAAAAEAACcQAAAAECNhJ+tqamY7MgmhFRUZNyH5ij8EpKgZAFvbCOQg9lYo6Ljm1z47Pa0wT8AzfJ+RwA==", "35600e75-4e67-489b-848c-a7b99eceb532" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "addd0c13-6a3f-4706-afc8-219f5e89badd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07131e56-50ad-4395-af2c-b9dc3046114b", "AQAAAAEAACcQAAAAEJadL++KpBx5OTB2FaujTiYfAs7pD91FxnenK3Q1BQIhQrIiXCpWIAsVuBIPcepeUQ==", "9723c8e0-588b-47d7-b1a3-941e7469efd2" });

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
    }
}
