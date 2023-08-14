using GamesNexus.Web.ViewModels.Game;
using GamesNexus.Web.ViewModels.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Services.Data.Interfaces
{
    public interface INewsService
    {
        public Task<IEnumerable<NewsIndexViewModel>> LastFiveNewsIndexAsync();
        Task<IEnumerable<NewsAllViewModel>> AllAsync();
        
    }
}
