using GamesNexus.Web.ViewModels.Genre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Services.Data.Interfaces
{
    public interface IGenreService
    {
        Task<IEnumerable<GameSelectGenreFormModel>> AllGenresAsync();
        Task<bool> ExistsByIdAsync(int id);
    }
}
