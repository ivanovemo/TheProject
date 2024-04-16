using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheProject.Infrastructure.Migrations
{
    public partial class SeedMoreStableMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "23ddf766-a9b9-44b4-878f-e2e7b1645ac3", "AQAAAAEAACcQAAAAEKrdr1Zs5EJrw3b2Bv+nzkSMUQSvMIWnGQHj32/Ubq394O1WYfz7n3Me3pvRCVu/8Q==", "f3fb9306-3d92-4794-b96b-7eccf681bd23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d64777e-f833-4eca-803b-8eb1b0670a5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e473b7c3-afe8-4df9-b48e-8f0ebfafda95", "AQAAAAEAACcQAAAAEJkDdpzBmpjcQFFZ+EVclzFgn2LqmoR05+7HvPrhHkPwMYyNlpg8KrY6OZUREzULOg==", "ea68770f-5fec-4337-8ff0-d9be7a0d42b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b79f761-5a4e-4457-a53b-cfc7c36ab084",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adb7b306-56c2-45b9-aab9-21ef7edd94ed", "AQAAAAEAACcQAAAAEKpPumG0iHs8ck7Btl9olhB8w9iShstULX3MCD0wAJ7wh9ze/uq9WUu/8GjJgjccVg==", "110c9fac-7353-4bcf-81a3-683fde9eb9b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c3438cd-8332-4e95-9a5e-adb64ec972d6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f6b200d-937e-4100-af4c-7eb4e9146f44", "AQAAAAEAACcQAAAAEAIo16uV9CtC8+EUecE/775HyPRcEMnT13rnTNWGY8d6UGo1G/bEhXBtgANcj4I9/A==", "56ac2269-7413-4f56-b36b-3c4c27865edd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "addd0c13-6a3f-4706-afc8-219f5e89badd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e01fc90c-6c6b-4692-bbe5-46d698e97dc5", "AQAAAAEAACcQAAAAEMC1FxBOMdsgM9j0EF4w6g1oC3vogMZFbaffqrgOubiJSvNWu0Dp5kz+16nU90ujgw==", "061b728b-8028-4f04-aa9a-228d3c4fcdb0" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Health and Wellness" },
                    { 5, "Environmental Science and Sustainability" },
                    { 6, "Engineering and Robotics" },
                    { 7, "Language and Communication" },
                    { 8, "Data Science and Analytics" },
                    { 9, "History and Culture" },
                    { 10, "Personal Development and Leadership" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "EndDate", "ImageUrl", "Interested", "StartDate", "Title" },
                values: new object[] { new Guid("6d38c7e6-84eb-411c-a528-53caecbdf5a5"), 3, "Unlock your creative potential and discover how to craft compelling stories with character, plot, and heart.", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.artshub.com.au/wp-content/uploads/sites/2/2022/05/shutterstock_516275947-e1652150413730.jpg", 85, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Creative Writing" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Bio", "CourseId", "FirstName", "LastName", "Photo" },
                values: new object[,]
                {
                    { new Guid("2c978901-e3ab-4e16-8f22-9693ee02da59"), "Renowned graphic designer with a passion for typography and brand identity.", new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Margot", "Robbie", "https://media.vanityfair.com/photos/636bc27c672701552ac8f48b/master/w_1600,c_limit/1222_Margot_Robbie_embed02.jpg" },
                    { new Guid("51e2a11b-d2fc-4822-ad0b-289099fd7fa7"), "Digital marketing guru with a focus on SEO and social media strategy.", new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Jennifer", "Aniston", "https://parade.com/.image/c_limit%2Ccs_srgb%2Cq_auto:good%2Cw_700/MTkwNTgxMDQyODUzMTkyODI5/jennifer-aniston-through-the-years.webp" },
                    { new Guid("8448aaa2-1ad0-4ed4-9566-d5e3b964d6ee"), "Data scientist specializing in machine learning and data visualization with over 8 years of experience.", new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Scarlett", "Johansson", "https://englishtribuneimages.blob.core.windows.net/gallary-content/2023/4/2023_4$largeimg_1660471345.jpg" },
                    { new Guid("bf3d6a40-d66d-4e7c-9709-bcaa5c199601"), "Expert in full stack development with over 10 years of experience.", new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Angelina", "Jolie", "https://i.pinimg.com/736x/b7/5b/49/b75b49e64989d5b5944c80f302228e2e.jpg" },
                    { new Guid("d39f8ccb-be75-4f68-99a1-0770be8aceb3"), "Project management professional with extensive experience preparing candidates for the PMP® certification.", new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Emma", "Watson", "https://image.tmdb.org/t/p/original/A14lLCZYDhfYdBa0fFRpwMDiwRN.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "Id", "CourseId", "Description", "Duration", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("04c445cd-dcad-4770-8592-e733ed63cd8d"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Creating and managing pay-per-click campaigns on Google Ads and social media platforms.", 120, new DateTime(2024, 3, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Effective PPC Campaigns" },
                    { new Guid("06093e9a-2f6f-41b3-8b50-d10b9c01cc2e"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Leveraging social media platforms to enhance brand visibility and engagement. Strategies for content creation and distribution.", 90, new DateTime(2024, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "Social Media Marketing and Branding" },
                    { new Guid("08bf81b8-f5c3-480f-9c6d-af142578172b"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Designing impactful visuals for websites, social media, and printed materials.", 140, new DateTime(2024, 5, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Creating Effective Visuals for Web and Print" },
                    { new Guid("1e336063-c642-4b81-856f-767fe51a9b6a"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Exploring linear regression, logistic regression, and clustering techniques using the Scikit-learn library.", 120, new DateTime(2024, 2, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "Machine Learning Models with Scikit-learn" },
                    { new Guid("2bfc7b68-df08-4c55-b351-d19bf9a43617"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Mastering the basics of Adobe Photoshop for photo editing and graphic creation.", 180, new DateTime(2024, 5, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "Adobe Photoshop Fundamentals" },
                    { new Guid("2c8e5628-9015-427b-9f63-b84d9bf7bb62"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "An exploration of color psychology, color palettes, and the importance of typography in design.", 110, new DateTime(2024, 4, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), "Basics of Design: Color Theory and Typography" },
                    { new Guid("30ba4b4c-4c76-4270-b9ac-f7eb71c5e01d"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "An overview of neural networks and deep learning. Implementing a basic neural network using TensorFlow.", 180, new DateTime(2024, 3, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), "Deep Learning Introduction with TensorFlow" },
                    { new Guid("633cd29b-83e4-4351-9380-f07f6b8422e7"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Creating a seamless connection between React and Node.js. Understanding REST APIs and integrating MongoDB for data storage.", 150, new DateTime(2024, 1, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), "Connecting Frontend with Backend" },
                    { new Guid("6445ff12-447c-46eb-9e37-de066ffe233b"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Identifying, analyzing, and responding to project risks to minimize their impact.", 90, new DateTime(2024, 6, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), "Risk Management and Mitigation" },
                    { new Guid("77c6b23a-23ea-44a5-8eac-123d88b882cd"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Understanding the PMBOK framework and the process groups and knowledge areas of project management.", 120, new DateTime(2024, 6, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to Project Management Framework" },
                    { new Guid("aa60b73c-309a-43f3-981d-dda4914127f9"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Techniques for creating realistic project schedules and ensuring timely project delivery.", 150, new DateTime(2024, 6, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "Project Scheduling and Time Management" },
                    { new Guid("c3f3f88c-ace6-4c48-be25-3bff8c09b2b5"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Diving deep into the world of search engine optimization, understanding keywords, and optimizing your website for Google.", 100, new DateTime(2024, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), "Understanding SEO" },
                    { new Guid("d34a7534-5dbc-4415-9ea0-df212d4fc1b3"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Getting started with Node.js, Express, and MongoDB. Installation and environment setup for full stack development.", 120, new DateTime(2024, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Setting Up Your Development Environment" },
                    { new Guid("e14acfa0-ac64-4781-94d1-b0c3df6f7c6c"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "An introduction to Python for data manipulation and analysis. Covering NumPy, pandas, and matplotlib libraries.", 90, new DateTime(2024, 2, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), "Python Programming for Data Science" },
                    { new Guid("e8085833-05e9-4a7d-8237-22b025c713cf"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "Introduction to React and its core principles. Building a simple application to understand components, state, and props.", 180, new DateTime(2024, 1, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), "Building Your First React Application" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CourseId", "Description", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("01b1449a-da49-4dcf-a7f5-b46cd5b4997b"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "Solid introduction to graphic design principles. Would appreciate more advanced modules for further learning.", 8, "2d64777e-f833-4eca-803b-8eb1b0670a5c" },
                    { new Guid("099df245-9d93-4dec-9ea7-aeb2d060c094"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Covers all the basics of digital marketing. Some topics could use more depth, but overall a good starter course.", 7, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("11fb3787-756b-48f0-a06b-3b9377e47aea"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Outstanding content and delivery on complex topics. The practical sessions were particularly beneficial. A must-take course for aspiring data scientists.", 10, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("15aaafb9-682b-4bfe-8fc9-7262e417e652"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "An incredibly comprehensive course that offered deep insights into full stack development with practical projects. Highly recommend for beginners and intermediate developers.", 9, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("17252a75-3d04-4a9f-96d3-dc5c6647e8fc"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "Provides a comprehensive overview of project management principles. Would benefit from more interactive content to keep the engagement high.", 7, "2d64777e-f833-4eca-803b-8eb1b0670a5c" },
                    { new Guid("3b9b1085-55b2-4b01-814f-56e08021fb35"), new Guid("6663d89a-3f07-4bea-b4f4-dc8b47efe599"), "Provides a robust foundation in data science. The course pace is fast but manageable. Python knowledge is a must to keep up.", 9, "2d64777e-f833-4eca-803b-8eb1b0670a5c" },
                    { new Guid("63e2072f-004b-49fe-a187-5fbc9ee25e11"), new Guid("557a4fcd-1f84-4487-a7bd-8240327c976b"), "A fascinating journey through the basics of graphic design. The course is well-structured, engaging, and creatively stimulating.", 9, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("954bb649-d478-4812-b31d-8889d8024036"), new Guid("f5b840fe-cd8b-44e1-8c5e-5cdbec1d4a0f"), "The course does an excellent job preparing for the PMP exam with detailed materials and practice questions. Some lessons felt a bit dry.", 8, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("a3110540-3eae-4395-9203-377b89109390"), new Guid("412588b2-b00f-49dc-b261-04b65edfd9f3"), "Great insights into digital marketing trends and tools. I particularly enjoyed the case studies and practical examples.", 8, "2d64777e-f833-4eca-803b-8eb1b0670a5c" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CourseId", "Description", "Rating", "UserId" },
                values: new object[] { new Guid("f479d51b-12a8-4f50-a38e-02229cce8194"), new Guid("9f9f3e8b-8fdd-4a38-b052-a5109123e2ab"), "This course was detailed with plenty of hands-on exercises. However, some prerequisites in JavaScript would have been helpful to mention for absolute beginners.", 8, "2d64777e-f833-4eca-803b-8eb1b0670a5c" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "EndDate", "ImageUrl", "Interested", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("78a56892-9dba-42cf-9328-e2cf026a5b97"), 4, "Learn how to offer initial support to adults who are developing a mental health problem or experiencing a mental health crisis.", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://addictionstraininginstitute.com/wp-content/uploads/2023/05/image-26.png", 70, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mental Health First Aid" },
                    { new Guid("ae35af86-a051-46f0-9aef-980d4e7585ac"), 5, "An exploration of sustainable living practices including renewable energy, green building, and sustainable agriculture.", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://media.restless.co.uk/uploads/2021/04/13_tips_for_sustainable_living.jpg", 65, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sustainable Living" },
                    { new Guid("c65ee8c7-189a-4730-9171-d89324a534de"), 6, "Get hands-on experience building and programming your first robot using Arduino and Raspberry Pi.", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://miro.medium.com/v2/resize:fit:960/1*o2QkJWlZWqtDa-g3luWT1Q.jpeg", 80, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to Robotics" },
                    { new Guid("f7b36bbc-397a-411d-b15c-b51355eb4465"), 7, "Learn Spanish from scratch! Master the basics of conversation, grammar, and vocabulary with this interactive course.", new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://effortlessconversations.com/wp-content/uploads/2023/10/is-spanish-hard-learn-spanish-text-on-laptop-1024x683.jpg", 95, new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spanish for Beginners" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Bio", "CourseId", "FirstName", "LastName", "Photo" },
                values: new object[] { new Guid("ad8b22f8-6a5d-49e3-b3e8-27305ac66f39"), "Lupita Nyong'o, an Oscar-winning actress known for her profound and emotionally resonant performances, turns her talents to the art of storytelling through creative writing. With a history of roles that span diverse narratives and cultures, Lupita brings a unique perspective to her course, 'Creative Writing: Unleash Your Imagination'. She focuses on helping students unlock their creative potential, encouraging them to explore their own stories with depth, empathy, and originality. Lupita's teaching method is deeply interactive, involving students in exercises that challenge them to think critically and creatively. Her lessons delve into character development, plot structuring, and the nuances of language, all while fostering an environment of support and inspiration. Lupita believes that everyone has a story to tell and that the act of writing can be a powerful tool for self-expression and reflection. Her passion for storytelling is infectious, making her classes a vibrant space for aspiring writers. Whether you're looking to write your first short story or embark on a novel, Lupita Nyong'o's course offers the guidance, inspiration, and techniques to help you navigate the journey of creative writing.", new Guid("6d38c7e6-84eb-411c-a528-53caecbdf5a5"), "Lupita", "Nyong'o", "https://lh3.googleusercontent.com/vDTbynIYVfDFAT5NXckaRIKpMbO2N7bn_Gb57_1k26vPDbmjwjWgnx22AwRQpl6pCtHxOo1xiNOlUdBjascfRQEk9Oadz2aJSeZvFp2e" });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "Id", "CourseId", "Description", "Duration", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("2fcd8fe2-4b5d-4cc7-949a-6fa5ef7054dd"), new Guid("6d38c7e6-84eb-411c-a528-53caecbdf5a5"), "Techniques for creating complex, believable characters that engage readers.", 90, new DateTime(2024, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Crafting Compelling Characters" },
                    { new Guid("ba9c80c4-e4ba-4686-a36a-0ba1b4f2660b"), new Guid("6d38c7e6-84eb-411c-a528-53caecbdf5a5"), "Mastering the art of storytelling, focusing on plot development and the emotional journey of the characters.", 105, new DateTime(2024, 9, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), "The Art of Storytelling" },
                    { new Guid("fad26f87-054b-4d65-9f51-e6b53cd91450"), new Guid("6d38c7e6-84eb-411c-a528-53caecbdf5a5"), "Exploring the key elements of creative writing, including narrative structure, character development, and voice.", 120, new DateTime(2024, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "Fundamentals of Creative Writing" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CourseId", "Description", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("3f298487-e0ab-4961-888f-e8eaeae8031a"), new Guid("6d38c7e6-84eb-411c-a528-53caecbdf5a5"), "A great primer for aspiring writers, packed with engaging exercises and insightful tips. More content on novel writing would be beneficial.", 8, "2d64777e-f833-4eca-803b-8eb1b0670a5c" },
                    { new Guid("b64f0956-b6b1-462b-a387-7fad8135e075"), new Guid("6d38c7e6-84eb-411c-a528-53caecbdf5a5"), "This course was a journey of discovery into the art of storytelling. The prompts and feedback helped me grow my writing in ways I hadn't imagined.", 9, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Bio", "CourseId", "FirstName", "LastName", "Photo" },
                values: new object[,]
                {
                    { new Guid("0672e9d3-5768-4bb0-92c2-03be4af6ebf2"), "Natalie Portman, a renowned actress and passionate environmentalist, brings her wealth of knowledge and experience to the realm of sustainable living. With a strong belief in the power of renewable energy solutions, she has dedicated herself to advocating for a greener planet. Her courses are rich with practical insights on how to incorporate sustainable practices into daily life, drawing from her own journey towards living sustainably. Natalie's dedication to environmental activism is matched by her ability to inspire and engage her students. Through her comprehensive approach, she explores the various dimensions of sustainability, from green building techniques to sustainable agriculture. Her engaging teaching style combines theory with real-world applications, making her classes both informative and transformative. Natalie encourages her students to think critically about their environmental impact and empowers them to make meaningful changes. Her vision is to create a community of learners who are equipped to lead the way in sustainable living. With Natalie as your guide, you'll embark on a journey to understand the importance of sustainability and how you can be a part of the solution. Join her to discover the practices that will not only benefit the environment but also enhance your quality of life.", new Guid("ae35af86-a051-46f0-9aef-980d4e7585ac"), "Natalie", "Portman", "https://facts.net/wp-content/uploads/2023/07/46-facts-about-natalie-portman-1690804650.jpg" },
                    { new Guid("5479a79a-7917-40e7-adad-5389896692b0"), "Meryl Streep, an icon of the silver screen, brings her unparalleled experience and insight to the world of mental health first aid. With a career that spans decades and roles that have touched on a myriad of human experiences, Meryl is uniquely positioned to lead a course on supporting others and yourself in times of mental health crises. Her course, 'Mental Health First Aid: Supporting Others and Yourself', draws upon her deep understanding of the human psyche, explored through her diverse roles. Meryl's approach to teaching is compassionate and informed, aiming to destigmatize mental health issues and provide practical support techniques. She advocates for empathy, understanding, and direct action in assisting those facing mental health challenges. The course covers recognizing signs of mental health problems, offering initial help, and guiding someone towards appropriate care. Meryl's passion for mental health awareness is palpable in her lectures, making her an inspiring figure for those looking to make a difference. With her guidance, students learn not only how to help others but also the importance of self-care and resilience. Enroll in Meryl Streep's course to embark on a meaningful journey towards becoming a supportive presence in the lives of those around you.", new Guid("78a56892-9dba-42cf-9328-e2cf026a5b97"), "Meryl", "Streep", "https://www.maconferenceforwomen.org/wp-content/uploads/sites/4/2017/04/meryl-streep.jpg" },
                    { new Guid("a8403747-cc2f-4fd4-baef-30188ffd5fb7"), "Penelope Cruz, an acclaimed actress with a rich background in language arts, has transitioned her passion into teaching Spanish to beginners. Her journey with languages began early in her career, allowing her to perform in a variety of roles across different cultures. Penelope's course, 'Spanish for Beginners: Master Basic Conversations', is a reflection of her love for the Spanish language and her desire to share it with others. Through her engaging teaching methods, Penelope emphasizes practical conversation skills, ensuring students gain confidence in their abilities to communicate. Her approach to teaching is infused with cultural insights, making learning a language not just about words but about understanding and appreciating a rich and vibrant culture. Penelope's classes are interactive and filled with real-life scenarios that prepare students for everyday conversations. With over a decade of experience in the film industry and numerous roles that required language mastery, Penelope brings authenticity and depth to her lessons. Her goal is to inspire a love for the Spanish language in her students, just as she has experienced in her travels and career. Join Penelope Cruz on this linguistic journey and unlock the door to new opportunities and connections through the beauty of the Spanish language.", new Guid("f7b36bbc-397a-411d-b15c-b51355eb4465"), "Penélope", "Cruz", "https://i.abcnewsfe.com/a/2e0c575c-cc96-480d-86a9-77f29924ac05/penelope-cruz-rt-gmh-240118_1705590269793_hpMain.jpg" },
                    { new Guid("fef23629-deaf-42c8-a0c4-300f402a9864"), "Anne Hathaway, with her deep passion for technology and education, spearheads our Introduction to Robotics course. Having spent years in the field of robotics engineering, Anne brings a wealth of practical knowledge and hands-on experience. Her course is designed to demystify the complex world of robotics and make it accessible to everyone, from beginners to more experienced enthusiasts. Anne's approach to teaching is deeply rooted in the belief that everyone has the potential to innovate. Through her engaging lectures and interactive workshops, students are encouraged to build and program their own robots, learning not just the technical skills but also the creativity and problem-solving abilities that are essential in robotics. Anne's dedication to her students goes beyond the classroom; she is committed to creating a supportive learning environment where questions are welcomed and exploration is encouraged. Her course covers a range of topics, from the basics of Arduino and Raspberry Pi to more advanced concepts in robotics engineering. Anne's mission is to inspire her students to pursue their interests in technology and to equip them with the skills needed to thrive in this exciting field. Join Anne Hathaway in this adventure into the world of robotics and discover the endless possibilities that await.", new Guid("c65ee8c7-189a-4730-9171-d89324a534de"), "Anne", "Hathaway", "https://www.usmagazine.com/wp-content/uploads/2023/11/Anne-Hathaway-revealed-that-she-was-told-that-her-career-would-be-over-by-the-time-she-turned-35-2.jpg?w=1000&quality=86&strip=all" }
                });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "Id", "CourseId", "Description", "Duration", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("126a1e12-d80f-4e9e-b905-68e8bf0ad349"), new Guid("ae35af86-a051-46f0-9aef-980d4e7585ac"), "Understanding sustainable farming practices and how they contribute to food security and environmental health.", 105, new DateTime(2024, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), "Sustainable Agriculture Techniques" },
                    { new Guid("249df054-2ef6-4e5a-97fe-bc1a6a03509e"), new Guid("f7b36bbc-397a-411d-b15c-b51355eb4465"), "Understanding the cultural nuances and expressions that are unique to the Spanish language.", 60, new DateTime(2024, 8, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), "Spanish Culture and Expressions" },
                    { new Guid("2c598d8b-d425-413a-b169-e879fa04e93a"), new Guid("c65ee8c7-189a-4730-9171-d89324a534de"), "Exploring more complex robotics projects using Raspberry Pi, focusing on IoT applications.", 120, new DateTime(2024, 7, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), "Advanced Robotics with Raspberry Pi" },
                    { new Guid("37424c57-8054-4733-b973-f5307da832dd"), new Guid("f7b36bbc-397a-411d-b15c-b51355eb4465"), "Learning common phrases and expressions to start speaking Spanish in daily situations.", 90, new DateTime(2024, 7, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Basic Spanish Conversation" },
                    { new Guid("4a0a6230-0558-48a7-ad77-b3e1fcf9191c"), new Guid("78a56892-9dba-42cf-9328-e2cf026a5b97"), "Strategies for raising awareness and reducing stigma associated with mental health issues.", 75, new DateTime(2024, 9, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), "Promoting Mental Health Awareness" },
                    { new Guid("60adcec9-8d80-469d-a965-ebd601bb800b"), new Guid("78a56892-9dba-42cf-9328-e2cf026a5b97"), "Techniques for providing immediate, short-term help to individuals experiencing a mental health crisis.", 120, new DateTime(2024, 8, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "Crisis Intervention Strategies" },
                    { new Guid("832ca540-9464-4c07-aa5e-094c0a96e7af"), new Guid("ae35af86-a051-46f0-9aef-980d4e7585ac"), "Exploring the principles of green building and sustainable design in modern architecture.", 90, new DateTime(2024, 6, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "Green Building Design" },
                    { new Guid("8c9c5d85-357b-4534-bc3d-bf808bee4471"), new Guid("ae35af86-a051-46f0-9aef-980d4e7585ac"), "An introduction to the different types of renewable energy sources and their impact on sustainable living.", 120, new DateTime(2024, 6, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), "Renewable Energy Basics" },
                    { new Guid("92610322-ba68-4d0e-8e33-39500f85b1ff"), new Guid("f7b36bbc-397a-411d-b15c-b51355eb4465"), "Covering the foundational grammar needed to build sentences and communicate effectively in Spanish.", 75, new DateTime(2024, 8, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "Grammar Essentials" },
                    { new Guid("a4106731-4c64-4e17-90c6-e8a4539c17b1"), new Guid("78a56892-9dba-42cf-9328-e2cf026a5b97"), "An overview of mental health, including common conditions and the importance of mental wellbeing.", 90, new DateTime(2024, 8, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), "Understanding Mental Health" },
                    { new Guid("c03cc323-fcb9-40e7-a0b4-4f9740c8fee5"), new Guid("c65ee8c7-189a-4730-9171-d89324a534de"), "Step-by-step guidance on creating a simple robot, focusing on the basics of mechanical design and programming.", 180, new DateTime(2024, 7, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "Building Your First Robot" },
                    { new Guid("d378a858-27c0-4975-90e3-b26569db3b31"), new Guid("c65ee8c7-189a-4730-9171-d89324a534de"), "Introduction to programming with Arduino, including sensor integration and basic robotics control.", 90, new DateTime(2024, 7, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "Arduino Programming Basics" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CourseId", "Description", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("204b0e48-8f0a-4d50-aa43-bde3da67c8e2"), new Guid("78a56892-9dba-42cf-9328-e2cf026a5b97"), "Important and timely content that's presented in an accessible way. This course is essential for anyone looking to understand more about mental health.", 9, "2d64777e-f833-4eca-803b-8eb1b0670a5c" },
                    { new Guid("2231b420-d84a-4aa6-9429-1f9be6af4a35"), new Guid("ae35af86-a051-46f0-9aef-980d4e7585ac"), "Inspirational course that offers practical advice on living more sustainably. It's comprehensive and thought-provoking.", 10, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("278a17ed-d393-474f-b45a-ac06fd9c9072"), new Guid("ae35af86-a051-46f0-9aef-980d4e7585ac"), "A great introduction to sustainability. It covers a wide range of topics and provides actionable steps to make a difference.", 9, "2d64777e-f833-4eca-803b-8eb1b0670a5c" },
                    { new Guid("39393062-cad4-4b38-9b30-5355945505e5"), new Guid("f7b36bbc-397a-411d-b15c-b51355eb4465"), "A solid introduction to Spanish that makes learning a new language less daunting. More advanced follow-up courses would be appreciated.", 8, "2d64777e-f833-4eca-803b-8eb1b0670a5c" },
                    { new Guid("7ef7caa9-9ee2-43a0-8902-9bfe33b63a6e"), new Guid("c65ee8c7-189a-4730-9171-d89324a534de"), "A good foundational course in robotics that could be improved by updating some of the course materials and resources.", 7, "2d64777e-f833-4eca-803b-8eb1b0670a5c" },
                    { new Guid("81e38522-283a-43fa-9c53-d320ac700856"), new Guid("f7b36bbc-397a-411d-b15c-b51355eb4465"), "Excellent course for beginners. The interactive exercises and practical conversation practice were very helpful.", 9, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("982d8f63-3e7b-4cf0-bd25-8215b56e5b3a"), new Guid("78a56892-9dba-42cf-9328-e2cf026a5b97"), "Extremely valuable course offering crucial insights into mental health support. Highly recommended for everyone.", 10, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" },
                    { new Guid("ac74c63e-13c3-40bd-a2d8-d28e3c036c32"), new Guid("c65ee8c7-189a-4730-9171-d89324a534de"), "Engaging and hands-on introduction to robotics. While some technical aspects can be challenging, the course is extremely rewarding.", 8, "6c3438cd-8332-4e95-9a5e-adb64ec972d6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("0672e9d3-5768-4bb0-92c2-03be4af6ebf2"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("2c978901-e3ab-4e16-8f22-9693ee02da59"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("51e2a11b-d2fc-4822-ad0b-289099fd7fa7"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("5479a79a-7917-40e7-adad-5389896692b0"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("8448aaa2-1ad0-4ed4-9566-d5e3b964d6ee"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("a8403747-cc2f-4fd4-baef-30188ffd5fb7"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("ad8b22f8-6a5d-49e3-b3e8-27305ac66f39"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("bf3d6a40-d66d-4e7c-9709-bcaa5c199601"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("d39f8ccb-be75-4f68-99a1-0770be8aceb3"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("fef23629-deaf-42c8-a0c4-300f402a9864"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("04c445cd-dcad-4770-8592-e733ed63cd8d"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("06093e9a-2f6f-41b3-8b50-d10b9c01cc2e"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("08bf81b8-f5c3-480f-9c6d-af142578172b"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("126a1e12-d80f-4e9e-b905-68e8bf0ad349"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("1e336063-c642-4b81-856f-767fe51a9b6a"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("249df054-2ef6-4e5a-97fe-bc1a6a03509e"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("2bfc7b68-df08-4c55-b351-d19bf9a43617"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("2c598d8b-d425-413a-b169-e879fa04e93a"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("2c8e5628-9015-427b-9f63-b84d9bf7bb62"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("2fcd8fe2-4b5d-4cc7-949a-6fa5ef7054dd"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("30ba4b4c-4c76-4270-b9ac-f7eb71c5e01d"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("37424c57-8054-4733-b973-f5307da832dd"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("4a0a6230-0558-48a7-ad77-b3e1fcf9191c"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("60adcec9-8d80-469d-a965-ebd601bb800b"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("633cd29b-83e4-4351-9380-f07f6b8422e7"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("6445ff12-447c-46eb-9e37-de066ffe233b"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("77c6b23a-23ea-44a5-8eac-123d88b882cd"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("832ca540-9464-4c07-aa5e-094c0a96e7af"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("8c9c5d85-357b-4534-bc3d-bf808bee4471"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("92610322-ba68-4d0e-8e33-39500f85b1ff"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("a4106731-4c64-4e17-90c6-e8a4539c17b1"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("aa60b73c-309a-43f3-981d-dda4914127f9"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("ba9c80c4-e4ba-4686-a36a-0ba1b4f2660b"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("c03cc323-fcb9-40e7-a0b4-4f9740c8fee5"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("c3f3f88c-ace6-4c48-be25-3bff8c09b2b5"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("d34a7534-5dbc-4415-9ea0-df212d4fc1b3"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("d378a858-27c0-4975-90e3-b26569db3b31"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("e14acfa0-ac64-4781-94d1-b0c3df6f7c6c"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("e8085833-05e9-4a7d-8237-22b025c713cf"));

            migrationBuilder.DeleteData(
                table: "Lectures",
                keyColumn: "Id",
                keyValue: new Guid("fad26f87-054b-4d65-9f51-e6b53cd91450"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("01b1449a-da49-4dcf-a7f5-b46cd5b4997b"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("099df245-9d93-4dec-9ea7-aeb2d060c094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("11fb3787-756b-48f0-a06b-3b9377e47aea"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("15aaafb9-682b-4bfe-8fc9-7262e417e652"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("17252a75-3d04-4a9f-96d3-dc5c6647e8fc"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("204b0e48-8f0a-4d50-aa43-bde3da67c8e2"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("2231b420-d84a-4aa6-9429-1f9be6af4a35"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("278a17ed-d393-474f-b45a-ac06fd9c9072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("39393062-cad4-4b38-9b30-5355945505e5"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("3b9b1085-55b2-4b01-814f-56e08021fb35"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("3f298487-e0ab-4961-888f-e8eaeae8031a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("63e2072f-004b-49fe-a187-5fbc9ee25e11"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("7ef7caa9-9ee2-43a0-8902-9bfe33b63a6e"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("81e38522-283a-43fa-9c53-d320ac700856"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("954bb649-d478-4812-b31d-8889d8024036"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("982d8f63-3e7b-4cf0-bd25-8215b56e5b3a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("a3110540-3eae-4395-9203-377b89109390"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("ac74c63e-13c3-40bd-a2d8-d28e3c036c32"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("b64f0956-b6b1-462b-a387-7fad8135e075"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("f479d51b-12a8-4f50-a38e-02229cce8194"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6d38c7e6-84eb-411c-a528-53caecbdf5a5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("78a56892-9dba-42cf-9328-e2cf026a5b97"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ae35af86-a051-46f0-9aef-980d4e7585ac"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c65ee8c7-189a-4730-9171-d89324a534de"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f7b36bbc-397a-411d-b15c-b51355eb4465"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

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
    }
}
