using GamesNexus.Services.Data.Interfaces;

using GamesNexus.Web.ViewModels.Game;
using GamesNexus.Web.ViewModels.Home;
using GamesNexus.Web.ViewModels.News;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using static GamesNexus.Common.GeneralApplicationConstants;

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
            if (this.User.IsInRole(AdminRoleName))
            {
               return this.RedirectToAction("Index", "Home", new { Area = AdminAreaName });
            }

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
        public IActionResult Error(int statusCode)
        {
            if (statusCode== 400|| statusCode==404)
            {
                return this.View("Error404");
            }
            return View();
        }
    }
}