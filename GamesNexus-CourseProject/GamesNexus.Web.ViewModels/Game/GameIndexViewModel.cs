using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Web.ViewModels.Game
{
    public class GameIndexViewModel
    {

        public GameIndexViewModel()
        {
            this.Genres = new HashSet<string>();
        }
        public long Id { get; set; }

        public string Title { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public ICollection<string> Genres { get; set; }

    }
}
