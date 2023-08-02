using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [MaxLength(GPUMaxLenght)]
        public string? GPU { set; get; }

        [MaxLength(CPUMaxLenght)]
        public string? CPU { set; get; }

        [MaxLength(OSMaxLenght)]
        public string? OS { set; get; }
        public int RAM { set; get; }

    }
}
