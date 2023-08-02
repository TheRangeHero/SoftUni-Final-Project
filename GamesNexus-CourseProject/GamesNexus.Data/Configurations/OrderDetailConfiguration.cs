using GamesNexus.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(od => new
            {
                od.GameId,
                od.OrderId
            });

            builder
                .HasOne(od => od.Game)
                .WithMany(g => g.OrderDetail)
                .HasForeignKey(od => od.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(od => od.Order)
                 .WithMany(o => o.OrderDetail)
                 .HasForeignKey(od => od.OrderId)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
