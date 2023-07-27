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
    public class DiscussionConfiguration : IEntityTypeConfiguration<Discussion>
    {
        public void Configure(EntityTypeBuilder<Discussion> builder)
        {
            builder
                .Property(d => d.CreatedAt)
                .HasColumnType("datetime2");

            builder
                .HasMany(c => c.Comments)
                .WithOne(d => d.Discussion)
                .HasForeignKey(d => d.DiscussionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
