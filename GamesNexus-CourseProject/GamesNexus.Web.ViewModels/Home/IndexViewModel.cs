using GamesNexus.Web.ViewModels.Game;
using GamesNexus.Web.ViewModels.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            this.GameIndexViewModel = new HashSet<GameIndexViewModel>();
            this.NewsIndexViewModels = new HashSet<NewsIndexViewModel>();
        }

        public IEnumerable<GameIndexViewModel> GameIndexViewModel { get; set; }
        public IEnumerable<NewsIndexViewModel> NewsIndexViewModels { get; set; }
    }
}
