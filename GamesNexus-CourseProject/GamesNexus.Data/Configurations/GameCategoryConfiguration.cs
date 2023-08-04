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
    public class GameCategoryConfiguration : IEntityTypeConfiguration<GameCategory>
    {
        public void Configure(EntityTypeBuilder<GameCategory> builder)
        {
            builder
                .HasKey(cg => new
                {
                    cg.GameId,
                    cg.CategoryId
                });

            builder.HasData(GenerateGameCategory());
        }

        private GameCategory[] GenerateGameCategory()
        {
            ICollection<GameCategory> gameCategories = new HashSet<GameCategory>();

            GameCategory gameCategory;

            gameCategory = new GameCategory()
            {
                GameId = 1,
                CategoryId = 2
            };
            gameCategories.Add(gameCategory);

            gameCategory = new GameCategory()
            {
                GameId = 2,
                CategoryId = 1
            };
            gameCategories.Add(gameCategory);

            gameCategory = new GameCategory()
            {
                GameId = 3,
                CategoryId = 2
            };
            gameCategories.Add(gameCategory);

            return gameCategories.ToArray();
        }
    }
}
