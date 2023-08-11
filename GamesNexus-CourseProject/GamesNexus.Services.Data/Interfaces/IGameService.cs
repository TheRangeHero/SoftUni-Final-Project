using GamesNexus.Web.ViewModels.Game;

namespace GamesNexus.Services.Data.Interfaces
{
    public interface IGameService
    {
        Task <IEnumerable<GameAllViewModel>> AllAsync ();
        Task<bool> ExistsByIdAsync (int Id);
        Task<GameDetailViewModel> GameDetailsById (int Id);
        Task <IEnumerable<GameIndexViewModel>> LastFiveGamesIndexAsync ();

    }
}
