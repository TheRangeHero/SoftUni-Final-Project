using GamesNexus.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(this.GenerateCategories());
        }

        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;
            category = new Category()
            {
                Id = 1,
                Name = "Single-player"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Multi-player"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "LAN"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 4,
                Name = "Co-op"
            };

            return categories.ToArray();
        }
    }
    
}
