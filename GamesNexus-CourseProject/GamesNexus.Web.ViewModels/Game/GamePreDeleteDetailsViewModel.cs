using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Web.ViewModels.Game
{
    public class GamePreDeleteDetailsViewModel
    {
        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        [Display(Name ="Image Link")]
        public string ImageURL { get; set; } = null!;
    }
}
