using GamesNexus.Data.Common;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.Infrastructure.Extensions;
using GamesNexus.Web.ViewModels.Game;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static GamesNexus.Common.NotificationMessagesConstants;

namespace GamesNexus.Web.Controllers
{

    public class GameController : BaseController
    {
        private readonly IGameService gameService;
        private readonly IPublisherService publisherService;
        private readonly ICategoryService categoryService;
        private readonly IGenreService genreService;

        public GameController(IGameService _gameService, 
                              IPublisherService _publisherService, 
                              ICategoryService _categoryService, 
                              IGenreService _genreService)
        {
            this.gameService = _gameService;
            this.categoryService = _categoryService;
            this.genreService = _genreService;
            this.publisherService = _publisherService;

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
        public async Task<IActionResult> Details(int Id)
        {
            bool gameExists = await gameService.ExistsByIdAsync(Id);
            if (!gameExists)
            {
                TempData[ErrorMessage] = "Game with the provided id does not exist!";

                return RedirectToAction("All", "Game");
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

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isPublisher = await this.publisherService.PublisherExistsByUserId(this.User.GetId()!);
            if (!isPublisher)
            {
                this.TempData[ErrorMessage] = "You must become a publisher in order to add new games!";
                return RedirectToAction("Become", "Publisher");
            }

            GameAddFromModel model = new GameAddFromModel()
            {
                Categories = await this.categoryService.AllCategoriesAsync(),
                Genres = await this.genreService.AllGenresAsync(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(GameAddFromModel model)
        {
            bool isPublisher = await this.publisherService.PublisherExistsByUserId(this.User.GetId()!);           

            if (!isPublisher)
            {
                this.TempData[ErrorMessage] = "You must become a publisher in order to add new games!";
                return RedirectToAction("Become", "Publisher");
            }



            //bool categoryExists = await this.categoryService.ExistsById(model.CategoryId);

            foreach (var category in model.Categories)
            {
                bool categoryExists = await this.categoryService.ExistsByIdAsync(category.Id);
                if (!categoryExists)
                {
                    ModelState.AddModelError(nameof(model.CategoryId), "Selected category does not exists!");
                }
            }

            foreach (var genre in model.Genres)
            {
                bool genereExists = await this.genreService.ExistsByIdAsync(genre.Id);
                if (!genereExists)
                {
                    ModelState.AddModelError(nameof(model.GenreId), "Selected genere does not exists!");
                }
            }

            if (!ModelState.IsValid)
            {
                model.Categories= await this.categoryService.AllCategoriesAsync();
                model.Genres = await this.genreService.AllGenresAsync();


                return this.View(model);
            }

            try
            {
                string? publisherId = await this.publisherService.PublisherIdByUserIdAsync(this.User.GetId()!);
                await this.gameService.CreateAsync(model, publisherId!);
            }
            catch (Exception)
            {

                this.ModelState.AddModelError(string.Empty, "Unexpected error occured while trying to add your new house! Please try again later or contact administrator!");

                model.Categories = await this.categoryService.AllCategoriesAsync();
                model.Genres = await this.genreService.AllGenresAsync();
                return this.View(model);
            }

            return this.RedirectToAction("All","Game");
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] =
                            "Unexpected error occurred! Please try again later or contact administrator";

            return RedirectToAction("Index", "Home");
        }
    }
}
