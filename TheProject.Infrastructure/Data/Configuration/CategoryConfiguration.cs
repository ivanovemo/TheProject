using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Infrastructure.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(SeedCategories());
        }

        private List<Category> SeedCategories()
        {
            var categories = new List<Category>()
            {
                new Category() { Id = 1, Name = "Technology and Computer Science" },
                new Category() { Id = 2, Name = "Business and Entrepreneurship" },
                new Category() { Id = 3, Name = "Creative Arts and Design" },
                new Category() { Id = 4, Name = "Health and Wellness" },
                new Category() { Id = 5, Name = "Environmental Science and Sustainability" },
                new Category() { Id = 6, Name = "Engineering and Robotics" },
                new Category() { Id = 7, Name = "Language and Communication" },
                new Category() { Id = 8, Name = "Data Science and Analytics" },
                new Category() { Id = 9, Name = "History and Culture" },
                new Category() { Id = 10, Name = "Personal Development and Leadership" }
            };

            return categories;
        }
    }
}