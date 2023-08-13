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
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder
                .Property(i => i.Id)
                .HasColumnType("bigint");

            builder
               .Property(d => d.ReleaseDate)
               .HasDefaultValue(DateTime.UtcNow);

            builder.Property(p => p.Price)
                .HasPrecision(10, 2);

            builder
                .HasMany(r => r.Reviews)
                .WithOne(g => g.Game)
                .HasForeignKey(g => g.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateGames());
        }

        private Game[] GenerateGames()
        {
            ICollection<Game> games = new HashSet<Game>();

            Game game;
            game = new Game()
            {
                Id = 1,
                Title = "League of Legends",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras tellus nunc, porttitor vel sapien eget, ornare tristique mauris. Donec diam neque, auctor et dui non.",
                Price = 10.25M,
                Developer = "Riot Games",
                PublisherId = Guid.Parse("DAE07E76-9F5D-4BFB-800B-C0DFB0EFEC5B"),
                GPU = "4 GB VRAM, AMD Radeon R9 380 or NVIDIA GeForce GTX 960 DirectX: Version 12",
                CPU = "AMD Ryzen 3 1200 or Intel Core i5-2500",
                OS = "Windows 10 (20H1 version or newer, 64-bit versions)",
                Storage = "90 GB available space",
                RAM = "8 GB RAM",
                AdditionalNotes = "SSD recommended, 60 FPS, 1920x1080 in ultra",
                Image1URL = "https://media.wired.co.uk/photos/606da9336ab54fce4fbb245f/master/w_1280,c_limit/lol_1.jpg",
                Image2URL = "https://i.pinimg.com/564x/c5/6c/77/c56c774ee09e3e16bf12460dea765109.jpg",
                VideoURL = "https://www.leagueoflegends.com/static/hero-0632cbf2872c5cc0dffa93d2ae8a29e8.webm"
            };
            games.Add(game);

            game = new Game()
            {
                Id = 2,
                Title = "Spyro",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque consectetur gravida orci in dapibus. Mauris pharetra efficitur nisi ut vehicula. Nulla dapibus faucibus gravida. Nunc a eleifend sem, at tempus ante. Nunc tincidunt laoreet nisl, at viverra mauris ultricies iaculis. Nullam dui leo, mattis eu rutrum sed, vehicula at odio.",
                Price = 55.55M,
                Developer = "Insomniac Games",
                PublisherId = Guid.Parse("DAE07E76-9F5D-4BFB-800B-C0DFB0EFEC5B"),
                GPU = "NVIDIA GeForce GTX 960 (2 GB) | AMD Radeon RX 480",
                CPU = "Intel Core i5-2500K | AMD FX-8350",
                OS = "Windows 7",
                Storage = "40 GB available space",
                RAM = "8 GB RAM",
                Image1URL = "https://cdn.mobygames.com/covers/7240915-spyro-reignited-trilogy-xbox-one-front-cover.jpg",
                VideoURL = "https://cdn.akamai.steamstatic.com/steam/apps/256752581/movie480.webm?t=1560272971"
            };
            games.Add(game);

            game = new Game()
            {
                Id = 3,
                Title = "CS:GO",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla laoreet sagittis quam, et sollicitudin nulla.",
                Price = 20,
                Developer = "Valve Corporation, Hidden Path Entertainment",
                PublisherId = Guid.Parse("DAE07E76-9F5D-4BFB-800B-C0DFB0EFEC5B"),
                GPU = "Video card must be 256 MB or more and should be a DirectX 9-compatible with support for Pixel Shader 3.0",
                CPU = "Intel® Core™ 2 Duo E6600 or AMD Phenom™ X3 8750 processor or better",
                OS = "Windows® 7/Vista/XP",
                Storage = "15 GB available space",
                RAM = "2 GB RAM",
                Image1URL = "https://fanspace.gg/wp-content/uploads/2022/12/csgo-1-1024x576.jpg",
                Image2URL = "https://estnn.com/wp-content/uploads/2021/04/csgoft2.jpg.webp",
                VideoURL = "https://cdn.cloudflare.steamstatic.com/steam/apps/81958/movie480.webm?t=1554409259"
            };
            games.Add(game);

            return games.ToArray();
        }
    }
}
