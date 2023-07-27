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
                .HasMany(i=>i.Images)
                .WithOne(g=>g.Game)
                .HasForeignKey(g => g.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(v=>v.Videos)
                .WithOne(g=>g.Game)
                .HasForeignKey(g => g.GameId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
