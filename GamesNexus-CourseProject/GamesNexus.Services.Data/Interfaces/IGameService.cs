using GamesNexus.Web.ViewModels.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Services.Data.Interfaces
{
    public interface IGameService
    {
        Task <IEnumerable<GameAllViewModel>> AllAsync ();
        Task<bool> ExistsByIdAsync (int Id);
        Task<GameDetailViewModel> GameDetailsById (int Id);
    }
}
