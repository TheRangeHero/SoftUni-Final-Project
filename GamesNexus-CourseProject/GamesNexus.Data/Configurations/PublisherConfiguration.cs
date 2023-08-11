using GamesNexus.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Data.Configurations
{
    internal class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder
                .HasMany(g => g.PublishedGames)
                .WithOne(g => g.Publisher)
                .HasForeignKey(g => g.PublisherId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(n => n.News)
                .WithOne(u => u.Publisher)
                .HasForeignKey(u => u.PublisherId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
