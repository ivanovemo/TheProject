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
                },
                new Instructor
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Natalie",
                    LastName = "Portman",
                    Bio = "Natalie Portman, a renowned actress and passionate environmentalist, brings her wealth of knowledge and experience to the realm of sustainable living. With a strong belief in the power of renewable energy solutions, she has dedicated herself to advocating for a greener planet. Her courses are rich with practical insights on how to incorporate sustainable practices into daily life, drawing from her own journey towards living sustainably. Natalie's dedication to environmental activism is matched by her ability to inspire and engage her students. Through her comprehensive approach, she explores the various dimensions of sustainability, from green building techniques to sustainable agriculture. Her engaging teaching style combines theory with real-world applications, making her classes both informative and transformative. Natalie encourages her students to think critically about their environmental impact and empowers them to make meaningful changes. Her vision is to create a community of learners who are equipped to lead the way in sustainable living. With Natalie as your guide, you'll embark on a journey to understand the importance of sustainability and how you can be a part of the solution. Join her to discover the practices that will not only benefit the environment but also enhance your quality of life.",
                    Photo = "https://facts.net/wp-content/uploads/2023/07/46-facts-about-natalie-portman-1690804650.jpg",
                    CourseId = Guid.Parse("ae35af86-a051-46f0-9aef-980d4e7585ac")
                },
                new Instructor
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Anne",
                    LastName = "Hathaway",
                    Bio = "Anne Hathaway, with her deep passion for technology and education, spearheads our Introduction to Robotics course. Having spent years in the field of robotics engineering, Anne brings a wealth of practical knowledge and hands-on experience. Her course is designed to demystify the complex world of robotics and make it accessible to everyone, from beginners to more experienced enthusiasts. Anne's approach to teaching is deeply rooted in the belief that everyone has the potential to innovate. Through her engaging lectures and interactive workshops, students are encouraged to build and program their own robots, learning not just the technical skills but also the creativity and problem-solving abilities that are essential in robotics. Anne's dedication to her students goes beyond the classroom; she is committed to creating a supportive learning environment where questions are welcomed and exploration is encouraged. Her course covers a range of topics, from the basics of Arduino and Raspberry Pi to more advanced concepts in robotics engineering. Anne's mission is to inspire her students to pursue their interests in technology and to equip them with the skills needed to thrive in this exciting field. Join Anne Hathaway in this adventure into the world of robotics and discover the endless possibilities that await.",
                    Photo = "https://www.usmagazine.com/wp-content/uploads/2023/11/Anne-Hathaway-revealed-that-she-was-told-that-her-career-would-be-over-by-the-time-she-turned-35-2.jpg?w=1000&quality=86&strip=all",
                    CourseId = Guid.Parse("c65ee8c7-189a-4730-9171-d89324a534de")
                },
                new Instructor
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Penélope",
                    LastName = "Cruz",
                    Bio = "Penelope Cruz, an acclaimed actress with a rich background in language arts, has transitioned her passion into teaching Spanish to beginners. Her journey with languages began early in her career, allowing her to perform in a variety of roles across different cultures. Penelope's course, 'Spanish for Beginners: Master Basic Conversations', is a reflection of her love for the Spanish language and her desire to share it with others. Through her engaging teaching methods, Penelope emphasizes practical conversation skills, ensuring students gain confidence in their abilities to communicate. Her approach to teaching is infused with cultural insights, making learning a language not just about words but about understanding and appreciating a rich and vibrant culture. Penelope's classes are interactive and filled with real-life scenarios that prepare students for everyday conversations. With over a decade of experience in the film industry and numerous roles that required language mastery, Penelope brings authenticity and depth to her lessons. Her goal is to inspire a love for the Spanish language in her students, just as she has experienced in her travels and career. Join Penelope Cruz on this linguistic journey and unlock the door to new opportunities and connections through the beauty of the Spanish language.",
                    Photo = "https://i.abcnewsfe.com/a/2e0c575c-cc96-480d-86a9-77f29924ac05/penelope-cruz-rt-gmh-240118_1705590269793_hpMain.jpg",
                    CourseId = Guid.Parse("f7b36bbc-397a-411d-b15c-b51355eb4465")
                },
                new Instructor
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Meryl",
                    LastName = "Streep",
                    Bio = "Meryl Streep, an icon of the silver screen, brings her unparalleled experience and insight to the world of mental health first aid. With a career that spans decades and roles that have touched on a myriad of human experiences, Meryl is uniquely positioned to lead a course on supporting others and yourself in times of mental health crises. Her course, 'Mental Health First Aid: Supporting Others and Yourself', draws upon her deep understanding of the human psyche, explored through her diverse roles. Meryl's approach to teaching is compassionate and informed, aiming to destigmatize mental health issues and provide practical support techniques. She advocates for empathy, understanding, and direct action in assisting those facing mental health challenges. The course covers recognizing signs of mental health problems, offering initial help, and guiding someone towards appropriate care. Meryl's passion for mental health awareness is palpable in her lectures, making her an inspiring figure for those looking to make a difference. With her guidance, students learn not only how to help others but also the importance of self-care and resilience. Enroll in Meryl Streep's course to embark on a meaningful journey towards becoming a supportive presence in the lives of those around you.",
                    Photo = "https://www.maconferenceforwomen.org/wp-content/uploads/sites/4/2017/04/meryl-streep.jpg",
                    CourseId = Guid.Parse("78a56892-9dba-42cf-9328-e2cf026a5b97")
                },
                new Instructor
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Lupita",
                    LastName = "Nyong'o",
                    Bio = "Lupita Nyong'o, an Oscar-winning actress known for her profound and emotionally resonant performances, turns her talents to the art of storytelling through creative writing. With a history of roles that span diverse narratives and cultures, Lupita brings a unique perspective to her course, 'Creative Writing: Unleash Your Imagination'. She focuses on helping students unlock their creative potential, encouraging them to explore their own stories with depth, empathy, and originality. Lupita's teaching method is deeply interactive, involving students in exercises that challenge them to think critically and creatively. Her lessons delve into character development, plot structuring, and the nuances of language, all while fostering an environment of support and inspiration. Lupita believes that everyone has a story to tell and that the act of writing can be a powerful tool for self-expression and reflection. Her passion for storytelling is infectious, making her classes a vibrant space for aspiring writers. Whether you're looking to write your first short story or embark on a novel, Lupita Nyong'o's course offers the guidance, inspiration, and techniques to help you navigate the journey of creative writing.",
                    Photo = "https://lh3.googleusercontent.com/vDTbynIYVfDFAT5NXckaRIKpMbO2N7bn_Gb57_1k26vPDbmjwjWgnx22AwRQpl6pCtHxOo1xiNOlUdBjascfRQEk9Oadz2aJSeZvFp2e",
                    CourseId = Guid.Parse("6d38c7e6-84eb-411c-a528-53caecbdf5a5")
                }
            };

            return instructors;
        }
    }
}