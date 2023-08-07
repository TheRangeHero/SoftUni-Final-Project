using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Game;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static GamesNexus.Common.NotificationMessagesConstants;

namespace GamesNexus.Web.Controllers
{
    
    public class GameController : BaseController
    {
        private readonly IGameService gameService;

        public GameController(IGameService _gameService)
        {
            gameService = _gameService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            IEnumerable<GameAllViewModel> allGames = await gameService.AllAsync();
            return View(allGames);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details (int Id)
        {
            bool gameExists = await gameService.ExistsByIdAsync(Id);
            if (!gameExists)
            {
                TempData[ErrorMessage] = "Game with the provided id does not exist!";

                return RedirectToAction("All","Game");
            }

            try
            {
                GameDetailViewModel viewModel = await gameService.GameDetailsById(Id);

                return View(viewModel);
            }
            catch (Exception)
            {

                return GeneralError();
            }
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] =
                            "Unexpected error occurred! Please try again later or contact administrator";

            return RedirectToAction("Index", "Home");
        }
    }
}
