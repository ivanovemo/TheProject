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
                new Category()
                {
                    Id = 1,
                    Name = "Technology and Computer Science"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Business and Entrepreneurship"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Creative Arts and Design"
                }
            };

            return categories;
        }
    }
}