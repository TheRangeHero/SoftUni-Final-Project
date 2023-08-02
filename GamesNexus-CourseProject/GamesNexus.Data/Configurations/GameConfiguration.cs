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
    internal class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder
                .Property(i=>i.Id)
                .HasColumnType("bigint");

            builder
                .Property(r => r.ReleaseDate)
                .HasColumnType("date");

            builder.Property(p => p.Price)
                .HasPrecision(10, 2);

            builder
                .HasMany(r => r.Reviews)
                .WithOne(g => g.Game)
                .HasForeignKey(g => g.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(i => i.Images)
                .WithOne(g => g.Game)
                .HasForeignKey(g => g.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(v => v.Videos)
                .WithOne(g => g.Game)
                .HasForeignKey(g => g.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(g => g.SystemRequirement)
                .WithOne()
                .HasForeignKey<Game>(g => g.SystemRequirementId);

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
                PublisherId = Guid.Parse("A9AC2BF7-C3E8-4597-841B-21A6CE1B766B")
            };
            games.Add(game);

            game = new Game()
            {
                Id = 2,
                Title = "Spyro",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque consectetur gravida orci in dapibus. Mauris pharetra efficitur nisi ut vehicula. Nulla dapibus faucibus gravida. Nunc a eleifend sem, at tempus ante. Nunc tincidunt laoreet nisl, at viverra mauris ultricies iaculis. Nullam dui leo, mattis eu rutrum sed, vehicula at odio.",
                Price = 55.55M,
                Developer = "Insomniac Games",
                PublisherId = Guid.Parse("A9AC2BF7-C3E8-4597-841B-21A6CE1B766B")
            };
            games.Add(game);

            return games.ToArray();
        }
    }
}
