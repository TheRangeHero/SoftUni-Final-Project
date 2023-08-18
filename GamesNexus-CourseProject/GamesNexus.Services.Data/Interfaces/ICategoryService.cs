using GamesNexus.Web.ViewModels.Category;
using GamesNexus.Web.ViewModels.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Services.Data.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<GameSelectCategoryFormModel>> AllCategoriesAsync();
        Task<bool> ExistsByIdAsync(int id);
        Task<bool> ExistsByNameAsync(string name);
        Task CreateAsync(CreateCategoryViewModel formModel);
    }
}
