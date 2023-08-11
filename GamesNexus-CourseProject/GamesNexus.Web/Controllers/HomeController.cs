using GamesNexus.Services.Data.Interfaces;

using GamesNexus.Web.ViewModels.Game;
using GamesNexus.Web.ViewModels.Home;
using GamesNexus.Web.ViewModels.News;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GamesNexus.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IGameService gameService;
        private readonly INewsService newsService;
        
        public HomeController(IGameService _gameService, INewsService _newsService)
        {
            this.gameService = _gameService;
            this.newsService = _newsService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var gameViewModel = await gameService.LastFiveGamesIndexAsync();
            var newsViewModel = await newsService.LastFiveNewsIndexAsync();

            var indexViewModel = new IndexViewModel()
            {
                GameIndexViewModel = gameViewModel,
                NewsIndexViewModels = newsViewModel,
            };

            return View(indexViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}