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
            categories.Add(category);

            category = new Category()
            {
                Id = 5,
                Name = "Local & party"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 6,
                Name = "Online Competitive"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 7,
                Name = "Free to Play"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 8,
                Name = "Early Access"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 9,
                Name = "Demos"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 10,
                Name = "Cross-Platform Multiplayer"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 11,
                Name = "Full controller support"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 12,
                Name = "Tracked Controller Support"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 13,
                Name = "VR Only"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 14,
                Name = "VR Supported"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 15,
                Name = "Includes level editor"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 16,
                Name = "Remote Play on Phone/tablet"
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }

}
