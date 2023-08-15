using GamesNexus.Web.ViewModels.Discussion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Services.Data.Interfaces
{
    public interface IDiscussionService
    {
        Task<IEnumerable<AllDiscussionViewModel>> AllAsync();
        Task<DiscussionDetailView> GetDiscussionByIdAsync(int id);
        Task<int> CreateAsync(DiscussionCreateViewModel model, string userId);
        Task<bool> DiscussionExistsByIdAsync(int id);
        Task<bool> IsUserWithIdPublisherOfDiscussionWithIdAsync(int disccussonId, string userId);
        Task DeleteDiscussionByIdAsync(int id);
    }
}
