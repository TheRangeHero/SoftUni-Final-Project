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
    public class GameImageConfiguration : IEntityTypeConfiguration<GameImage>
    {
        public void Configure(EntityTypeBuilder<GameImage> builder)
        {
            builder.HasData(GenerateGameImages());
        }

        private GameImage[] GenerateGameImages()
        {
            ICollection<GameImage> gameImages = new HashSet<GameImage>();

            GameImage gameImage;
            gameImage = new GameImage()
            {
                Id = 1,
                ImageUrl = "https://media.wired.co.uk/photos/606da9336ab54fce4fbb245f/master/w_1280,c_limit/lol_1.jpg",
                GameId = 1
            };
            gameImages.Add(gameImage);

            gameImage = new GameImage()
            {
                Id = 2,
                ImageUrl = "https://i.pinimg.com/564x/c5/6c/77/c56c774ee09e3e16bf12460dea765109.jpg",
                GameId = 1
            };
            gameImages.Add(gameImage);

            gameImage = new GameImage()
            {
                Id = 3,
                ImageUrl = "https://cdn.mobygames.com/covers/7240915-spyro-reignited-trilogy-xbox-one-front-cover.jpg",
                GameId = 2
            };
            gameImages.Add(gameImage);

            gameImage = new GameImage()
            {
                Id = 4,
                ImageUrl = "https://fanspace.gg/wp-content/uploads/2022/12/csgo-1-1024x576.jpg",
                GameId = 3
            };
            gameImages.Add(gameImage);

            gameImage = new GameImage()
            {
                Id = 5,
                ImageUrl = "https://estnn.com/wp-content/uploads/2021/04/csgoft2.jpg.webp",
                GameId = 3
            };
            gameImages.Add(gameImage);

            return gameImages.ToArray();
        }
    }
}
