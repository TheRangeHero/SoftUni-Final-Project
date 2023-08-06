using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Game;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamesNexus.Web.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly IGameService gameService;

        public GameController(IGameService _gameService)
        {
            gameService = _gameService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            IEnumerable<GameAllViewModel> allGames = await gameService.AllAsync();
            return View(allGames);
        }
    }
}
