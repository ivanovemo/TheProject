namespace TheProject.Infrastructure.Constants
{
    public static class Constants
    {
        public static class CategoryConstants
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 5;
        }
        public static class CourseConstants
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 5;

            public const int DescriptionMaxLength = 10000;
            public const int DescriptionMinLength = 10;
        }
        public static class InstructorConstants
        {
            public const int FirstNameMaxLength = 50;
            public const int FirstNameMinLength = 2;

            public const int LastNameMaxLength = 50;
            public const int LastNameMinLength = 2;

            public const int BioxMaxLength = 5000;
            public const int BioMinLength = 10;
        }
        public static class LectureConstants
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 5;

            public const int DescriptionMaxLength = 10000;
            public const int DescriptionMinLength = 10;
        }
        public static class ReviewConstants
        {
            public const int MinRating = 1;
            public const int MaxRating = 10;

            public const int DescriptionMaxLength = 10000;
            public const int DescriptionMinLength = 10;
        }
    }
}
