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

            systemRequirement = new SystemRequirement()
            {
                Id = 3,
                GPU = "Video card must be 256 MB or more and should be a DirectX 9-compatible with support for Pixel Shader 3.0",
                CPU = "Intel® Core™ 2 Duo E6600 or AMD Phenom™ X3 8750 processor or better",
                OS = "Windows® 7/Vista/XP",
                Storage = "15 GB available space",
                RAM = "2 GB RAM",
                GameId = 3
            };
            systemRequirements.Add(systemRequirement);

            return systemRequirements.ToArray();
        }
    }
}
