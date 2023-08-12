
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Web.ViewModels.Game
{
    public class GameAllViewModel
    {

        public long Id { get; set; }

        public string Title { get; set; } = null!;

        public string Image { get; set; } = null!;

       public decimal Price { get; set; }
    }
}
