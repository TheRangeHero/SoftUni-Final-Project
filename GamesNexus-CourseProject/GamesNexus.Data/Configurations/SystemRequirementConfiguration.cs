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
    public class SystemRequirementConfiguration : IEntityTypeConfiguration<SystemRequirement>
    {
        public void Configure(EntityTypeBuilder<SystemRequirement> builder)
        {
            builder.HasData(GenerateSystemRequirement());
        }

        private SystemRequirement[] GenerateSystemRequirement()
        {
            ICollection<SystemRequirement> systemRequirements = new HashSet<SystemRequirement>();

            SystemRequirement systemRequirement;

            systemRequirement = new SystemRequirement()
            {
                Id = 1,
                GPU = "4 GB VRAM, AMD Radeon R9 380 or NVIDIA GeForce GTX 960 DirectX: Version 12",
                CPU = "AMD Ryzen 3 1200 or Intel Core i5-2500",
                OS = "Windows 10 (20H1 version or newer, 64-bit versions)",
                Storage = "90 GB available space",
                RAM = "8 GB RAM",
                AdditionalNotes = "SSD recommended, 60 FPS, 1920x1080 in ultra",
                GameId = 1
            };
            systemRequirements.Add(systemRequirement);

            systemRequirement = new SystemRequirement()
            {
                Id = 2,
                GPU = "NVIDIA GeForce GTX 960 (2 GB) | AMD Radeon RX 480",
                CPU = "Intel Core i5-2500K | AMD FX-8350",
                OS = "Windows 7",
                Storage = "40 GB available space",
                RAM = "8 GB RAM",
                GameId = 2
            };
            systemRequirements.Add(systemRequirement);

            return systemRequirements.ToArray();
        }
    }
}
