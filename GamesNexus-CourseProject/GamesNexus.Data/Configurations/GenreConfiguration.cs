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
                Name = "Shooter"
            };
            genres.Add(genre);


            return genres.ToArray();
        }
    }
}
