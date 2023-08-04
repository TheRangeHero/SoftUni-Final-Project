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
    public class GameGenreConfiguration : IEntityTypeConfiguration<GameGenre>
    {
        public void Configure(EntityTypeBuilder<GameGenre> builder)
        {
            builder
                .HasKey(gg => new
                {
                    gg.GameId,
                    gg.GenreId
                });

            builder.HasData(GenerateGameGenres());
        }

        private GameGenre[] GenerateGameGenres()
        {
            ICollection<GameGenre> gameGenres = new HashSet<GameGenre>();

            GameGenre gameGenre;
            gameGenre = new GameGenre()
            {
                GameId = 1,
                GenreId = 2,
            };
            gameGenres.Add(gameGenre);

            gameGenre = new GameGenre()
            {
                GameId = 1,
                GenreId = 1
            };
            gameGenres.Add(gameGenre);

            gameGenre = new GameGenre()
            {
                GameId = 2,
                GenreId = 3,
            };
            gameGenres.Add(gameGenre);

            gameGenre = new GameGenre()
            {
                GameId = 2,
                GenreId = 1
            };
            gameGenres.Add(gameGenre);

            gameGenre = new GameGenre()
            {
                GameId = 3,
                GenreId = 1
            };
            gameGenres.Add(gameGenre);

            gameGenre = new GameGenre()
            {
                GameId = 3,
                GenreId = 5
            };
            gameGenres.Add(gameGenre);

            return gameGenres.ToArray();
        }
    }
}
