using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static GamesNexus.Common.EntityValidationConstants.SystemRequirement;

namespace GamesNexus.Data.Models
{
    public class SystemRequirement
    {
        [Key]
        public long Id { set; get; }

        [MaxLength(GPUMaxLength)]
        public string? GPU { set; get; }

        [MaxLength(CPUMaxLength)]
        public string? CPU { set; get; }

        [MaxLength(OSMaxLength)]
        public string? OS { set; get; }

        [MaxLength(StorageMaxLength)]
        public string? Storage { set; get; }

        [MaxLength(RAMMaxLength)]
        public string? RAM { set; get; }

        [MaxLength(AdditionalNotesMaxLength)]
        public string? AdditionalNotes { set; get; }

        public long GameId { set; get; }
        public Game Game { set; get; } = null!;


    }
}
