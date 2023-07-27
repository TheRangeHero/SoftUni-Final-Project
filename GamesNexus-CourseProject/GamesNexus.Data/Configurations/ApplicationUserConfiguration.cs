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
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                .Property(d => d.DateOfBirth)
                .HasColumnType("date");


            builder
                .HasOne(x => x.Wishlist)
                .WithOne(x => x.ApplicationUser)
                .HasForeignKey<Wishlist>(x => x.ApplicationUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(d => d.Discussions)
                .WithOne(u => u.ApplicationUser)
                .HasForeignKey(u => u.ApplicationUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(c => c.Comments)
                .WithOne(u => u.ApplicationUser)
                .HasForeignKey(u => u.ApplicationUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(r => r.Reviews)
                .WithOne(u => u.ApplicationUser)
                .HasForeignKey(u => u.ApplicationUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(n => n.News)
                .WithOne(u => u.ApplicationUser)
                .HasForeignKey(u => u.ApplicationUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(o => o.Orders)
                .WithOne(u => u.ApplicationUser)
                .HasForeignKey(u => u.ApplicationUserId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
