using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Web.ViewModels.SystemRequirement
{
    public class SystemRequirementAllViewModel
    {
        public SystemRequirementAllViewModel()
        {
            this.GPU = GPU ?? "No available information";
            this.CPU = CPU ?? "No available information";
            this.OS = OS ?? "No available information";
            this.Storage = Storage ?? "No available information";
            this.RAM = RAM ?? "No available information";
        }

        public long Id { get; set; }


        [Display(Name = "Graphics")]       
        public string GPU { get; set; }


        [Display(Name = "Processor")]
        public string CPU { get; set; }


        [Display(Name = "Operating System")]
        public string OS { get; set; }


        public string Storage { get; set; }


        [Display(Name ="Memory")]
        public string RAM { get; set; }


        [Display(Name = "Additional Notes")]
        public string AdditionalNotes { get; set; }
    }
}
