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

            public const int MaxDurationValue = 300;
            public const int MinDurationValue = 15;
        }
        public static class ReviewConstants
        {
            public const int MinRating = 1;
            public const int MaxRating = 10;

            public const int DescriptionMaxLength = 10000;
            public const int DescriptionMinLength = 10;
        }

        public static class Date
        {
            public const string Format = "MM/dd/yyyy";
        }

        public static class ErrorMessages
        {
            public const string Required = "The field {0} is required!";
            public const string Length = "The field {0} must be between {2} and {1} characters long!";
        }
    }
}
