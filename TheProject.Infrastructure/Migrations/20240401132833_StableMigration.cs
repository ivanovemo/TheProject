using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheProject.Infrastructure.Migrations
{
    public partial class StableMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0afe2b81-40c4-4ae7-9ebd-0ccaa1b0b64f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8b5a2c8-17c2-4bae-805b-87864040c36f", "AQAAAAEAACcQAAAAEHSd9vpql6Z0nIf8g0LxJgclbVvqYuX0eR5mSMjLIHRV3u2vqfPgTitzCpe9zeFnMg==", "ffcb7d99-09f2-4709-b761-a71fcc536e90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a612851b-a286-4f2a-940b-2e97dfbf60e8", "AQAAAAEAACcQAAAAENaM3/kr7cL8u1fY+xoXUxXDygur7GqcXCx6sAA0aEg2Ltm1yE+v+z3zFfZdh7aKnQ==", "ee0adb99-cec1-4bae-9e7f-14870e643b53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b79f761-5a4e-4457-a53b-cfc7c36ab084",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5bafd92-a3e2-4302-b993-2b12feb97ff7", "AQAAAAEAACcQAAAAEB0mUdWpcwOKfT8YS1SwmVTSrzv0lWhgsKoWCoe/pxVrkfUo7V1NzCFrVmQ5NkZg7Q==", "bea52b4d-0693-4c98-a1af-e777fab8b73f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e891cffa-2072-4eb0-b7cc-a3e4a9a4f3f5", "AQAAAAEAACcQAAAAEC9DkoELzEWYAI2HhERKwcW6cDzFFIHGdmHZeW1ODZXbPMN0yZGoVvhxS2HBhlLJjA==", "55e99052-1613-4848-be88-4d621dd1ca56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "addd0c13-6a3f-4706-afc8-219f5e89badd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84778c60-f7c2-49f7-9139-c75d8492d2ac", "AQAAAAEAACcQAAAAEBkvlTgvWlzirXONrT5cFoTxHSXIr5GFSz54R6695DQlfYcxe3gsnZfiMoWISLo5tQ==", "01ef4ba4-8b8e-4f32-ae3e-c7dd7fda57db" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Bio", "CourseId", "FirstName", "LastName", "Photo" },
                values: new object[,]
                {
                    { new Guid("0093f220-b118-4197-9d09-affce6d2f451"), "Renowned graphic designer with a passion for typography and brand identity.", new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Margot", "Robbie", "https://media.vanityfair.com/photos/636bc27c672701552ac8f48b/master/w_1600,c_limit/1222_Margot_Robbie_embed02.jpg" },
                    { new Guid("2c24853c-6ec1-441d-9973-bc2fc55bf34a"), "Data scientist specializing in machine learning and data visualization with over 8 years of experience.", new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Scarlett", "Johansson", "https://englishtribuneimages.blob.core.windows.net/gallary-content/2023/4/2023_4$largeimg_1660471345.jpg" },
                    { new Guid("61a286d3-7d6e-4b40-b88b-abedb579bc3a"), "Digital marketing guru with a focus on SEO and social media strategy.", new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Jennifer", "Aniston", "https://parade.com/.image/c_limit%2Ccs_srgb%2Cq_auto:good%2Cw_700/MTkwNTgxMDQyODUzMTkyODI5/jennifer-aniston-through-the-years.webp" },
                    { new Guid("8adb90b0-391a-45bb-94ac-ef48fca55c3d"), "Expert in full stack development with over 10 years of experience.", new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Angelina", "Jolie", "https://i.pinimg.com/736x/b7/5b/49/b75b49e64989d5b5944c80f302228e2e.jpg" },
                    { new Guid("f49abf98-a2c3-42ea-8383-09db9af96d6e"), "Project management professional with extensive experience preparing candidates for the PMP® certification.", new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Emma", "Watson", "https://image.tmdb.org/t/p/original/A14lLCZYDhfYdBa0fFRpwMDiwRN.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "Id", "CourseId", "Description", "Duration", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("1683ea44-d25e-46c9-a1fb-6bb19ab77acb"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Strategies and tips for tackling the PMP certification exam.", 220, new DateTime(2024, 6, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Preparing for the PMP Exam" },
                    { new Guid("16cd6450-8510-4660-ad51-1ba90303bd8b"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Analyzing data sets to summarize their main characteristics.", 120, new DateTime(2024, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "Exploratory Data Analysis" },
                    { new Guid("698eb3da-d997-4253-b341-a923b173bc62"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Covering the fundamental concepts and terminologies of project management.", 120, new DateTime(2024, 6, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "Project Management Basics" },
                    { new Guid("79ccf8cf-0cf5-4c90-861b-cdf1e83c7025"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Understanding the basics of web development with HTML and CSS.", 150, new DateTime(2024, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to HTML and CSS" },
                    { new Guid("7b12c626-bcd9-4a22-b5d7-8d6d3828c4c6"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Interactive web pages with JavaScript.", 180, new DateTime(2024, 1, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "JavaScript and the Web" },
                    { new Guid("a40432cf-b270-4349-aaa4-f553a98bb5ef"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Learn the basics of Search Engine Optimization to increase your website visibility.", 75, new DateTime(2024, 3, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "SEO Fundamentals" },
                    { new Guid("a7e0eea7-e847-43cd-8922-6c5241b174df"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Effective strategies for engaging with your audience on social media platforms.", 60, new DateTime(2024, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Social Media Marketing Strategies" },
                    { new Guid("a834bc50-3608-441b-85d3-3e1fa91f37d8"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Exploring the role of typography in graphic design and how to use it effectively.", 300, new DateTime(2024, 5, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "Typography in Design" },
                    { new Guid("ced31774-6e45-4e5a-9c4f-36bb2161d5c1"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "A deep dive into the core principles of graphic design, focusing on composition and layout.", 180, new DateTime(2024, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Design Principles: Composition and Layout" },
                    { new Guid("f0c61cfd-3ed8-46b3-980c-1cbc12acd694"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Introduction to Python and its libraries for data science.", 90, new DateTime(2024, 2, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), "Python for Data Science" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CourseId", "Description", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("7bf7f52a-bd90-492d-9de1-8eb8a5b26b19"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "The PMP prep course was detailed and well-structured. It helped me pass the exam on the first try.", 8, "addd0c13-6a3f-4706-afc8-219f5e89badd" },
                    { new Guid("7d55d2d0-5696-49d8-aff0-e0fc98d2bcc6"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Loved the practical approach to graphic design principles. The examples were very helpful.", 6, "addd0c13-6a3f-4706-afc8-219f5e89badd" },
                    { new Guid("968d6196-77ae-4880-961e-1b9ae5c843b1"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Excellent course on data science. Highly recommend for beginners and intermediates.", 9, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("ac85b605-c0e4-42e2-a3f6-6a655fb859c4"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "A comprehensive course that offers deep insights into full stack development.", 8, "6b79f761-5a4e-4457-a53b-cfc7c36ab084" },
                    { new Guid("f508c604-a46b-43fc-a1e2-ba1063688c2f"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "This course exceeded my expectations! The content was clear, and the projects were both challenging and rewarding.", 10, "addd0c13-6a3f-4706-afc8-219f5e89badd" },
                    { new Guid("fcadd006-f5c1-4278-90c4-8fd2340939e4"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Great insights into digital marketing strategies. Useful for all levels.", 7, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("0093f220-b118-4197-9d09-affce6d2f451"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("2c24853c-6ec1-441d-9973-bc2fc55bf34a"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("61a286d3-7d6e-4b40-b88b-abedb579bc3a"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("8adb90b0-391a-45bb-94ac-ef48fca55c3d"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("f49abf98-a2c3-42ea-8383-09db9af96d6e"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("1683ea44-d25e-46c9-a1fb-6bb19ab77acb"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("16cd6450-8510-4660-ad51-1ba90303bd8b"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("698eb3da-d997-4253-b341-a923b173bc62"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("79ccf8cf-0cf5-4c90-861b-cdf1e83c7025"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("7b12c626-bcd9-4a22-b5d7-8d6d3828c4c6"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("a40432cf-b270-4349-aaa4-f553a98bb5ef"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("a7e0eea7-e847-43cd-8922-6c5241b174df"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("a834bc50-3608-441b-85d3-3e1fa91f37d8"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("ced31774-6e45-4e5a-9c4f-36bb2161d5c1"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("f0c61cfd-3ed8-46b3-980c-1cbc12acd694"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("7bf7f52a-bd90-492d-9de1-8eb8a5b26b19"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("7d55d2d0-5696-49d8-aff0-e0fc98d2bcc6"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("968d6196-77ae-4880-961e-1b9ae5c843b1"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("ac85b605-c0e4-42e2-a3f6-6a655fb859c4"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("f508c604-a46b-43fc-a1e2-ba1063688c2f"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("fcadd006-f5c1-4278-90c4-8fd2340939e4"));

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
    }
}
