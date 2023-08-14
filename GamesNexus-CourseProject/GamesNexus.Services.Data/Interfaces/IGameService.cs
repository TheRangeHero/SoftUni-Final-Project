using GamesNexus.Web.ViewModels.Game;

namespace GamesNexus.Services.Data.Interfaces
{
    public interface IGameService
    {
        Task<IEnumerable<GameAllViewModel>> AllAsync();
        Task<bool> ExistsByIdAsync(long Id);
        Task<GameDetailViewModel> GameDetailsById(int Id);
        Task<IEnumerable<GameIndexViewModel>> LastFiveGamesIndexAsync();
        Task CreateAsync(GameAddFromModel formModel, string publisherId);
        Task<IEnumerable<GameAllViewModel>> AllByUserIdAsync(string userId);
        Task<IEnumerable<GameAllViewModel>> AllByPublisherIdAsync(string publisherId);
        Task<GameAddFromModel> GetGameForEditByIdAsync(long id);
        Task<bool> IsPublisherWithIdPublisherOfGameWithIdAsync(long gameId, string publisherId);
        Task EditGameByIdAndFormModelAsync (GameAddFromModel formModel, long id);
        Task<GamePreDeleteDetailsViewModel> GetGameForDeleteAsync(long id);
        Task DeleteGameByIdAsync (long id);
    }
}
