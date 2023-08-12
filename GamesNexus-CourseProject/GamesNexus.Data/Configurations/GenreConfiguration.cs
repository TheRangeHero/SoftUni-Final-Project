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
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(this.GenerateGenres());
        }

        private Genre[] GenerateGenres()
        {
            ICollection<Genre> genres = new HashSet<Genre>();

            Genre genre;
            genre = new Genre()
            {
                Id = 1,
                Name = "Action"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 2,
                Name = "Strategy"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 3,
                Name = "Adventure"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 4,
                Name = "Simulation"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 5,
                Name = "First-Person Shooter"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 6,
                Name = "Arcade & Rhythm"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 7,
                Name = "Third-Person Shooter"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 8,
                Name = "Platformer & Runner"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 9,
                Name = "Hack & Slash"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 10,
                Name = "Farming & Crafting"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 11,
                Name = "Rogue-Like"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 12,
                Name = "Strategy RPG"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 13,
                Name = "Turn-Based"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 14,
                Name = "Card & Board"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 15,
                Name = "Tower Defense"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 16,
                Name = "Puzzle"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 17,
                Name = "All Sports"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 18,
                Name = "Racing"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 19,
                Name = "Racing Sim"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 20,
                Name = "Sports Sim"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 21,
                Name = "Horror"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 22,
                Name = "Open world"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 23,
                Name = "Survival"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 24,
                Name = "Sci-Fi"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 25,
                Name = "Space & Flight"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 26,
                Name = "RPG"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 27,
                Name = "Battle Royale"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 28,
                Name = "MOBA"
            };
            genres.Add(genre);

            genre = new Genre()
            {
                Id = 29,
                Name = "MMO"
            };
            genres.Add(genre);


            return genres.ToArray();
        }
    }
}
