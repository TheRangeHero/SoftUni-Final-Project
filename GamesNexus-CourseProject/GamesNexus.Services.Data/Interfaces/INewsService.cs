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
        Task<NewsAllViewModel> NewsFullById(int Id);
        Task<bool> NewsExistsByIdAsync(int Id);
        Task CreateAsync(NewsAddFormModel formModel, string publisherId);
        public Task<IEnumerable<NewsAllViewModel>> AllByPublisherIdAsync(string userId);
        Task<bool> IsPublisherWithIdPublisherOfNewsWithIdAsync(int gameId, string publisherId);
        Task<NewsAddFormModel> GetNewsForEditByIdAsync(int id);
        Task EditNewsByIdAndFormModelAsync(NewsAddFormModel formModel, int id);
        Task<NewsAllViewModel> GetNewsForDeleteAsync(int id);
        Task DeleteNewsByIdAsync(int id);
    }
}
