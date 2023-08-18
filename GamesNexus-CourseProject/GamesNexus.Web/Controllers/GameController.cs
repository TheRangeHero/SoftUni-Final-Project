using GamesNexus.Data.Common;
using GamesNexus.Data.Models.Enums;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.Infrastructure.Extensions;
using GamesNexus.Web.ViewModels.Game;
using GamesNexus.Web.ViewModels.Review;
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
        public async Task<IActionResult> Details(long Id)
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

               return this.GeneralError();
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


            try
            {

            GameAddFromModel model = new GameAddFromModel()
            {
                Categories = await this.categoryService.AllCategoriesAsync(),
                Genres = await this.genreService.AllGenresAsync(),
            };

            return View(model);
            }
            catch (Exception)
            {

              return this.GeneralError();
            }

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

            foreach (var categoryId in model.SelectedCategoryIds)
            {
                bool categoryExists = await this.categoryService.ExistsByIdAsync(categoryId);
                if (!categoryExists)
                {
                    ModelState.AddModelError(nameof(model.SelectedCategoryIds), $"Selected category does not exists");
                }
            }

            foreach (var genreId in model.SelectedGenreIds)
            {
                bool genreExists = await this.genreService.ExistsByIdAsync(genreId);
                if (!genreExists)
                {
                    ModelState.AddModelError(nameof(model.SelectedGenreIds), $"Selected genere does not exists!");
                }
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await this.categoryService.AllCategoriesAsync();
                model.Genres = await this.genreService.AllGenresAsync();


                return this.View(model);
            }

            try
            {
                string? publisherId = await this.publisherService.GetPublisherIdByUserIdAsync(this.User.GetId()!);
                await this.gameService.CreateAsync(model, publisherId!);

                this.TempData[SuccessMessage] = "House was added successfully!";
            }
            catch (Exception)
            {

                this.ModelState.AddModelError(string.Empty, "Unexpected error occured while trying to add your new house! Please try again later or contact administrator!");

                model.Categories = await this.categoryService.AllCategoriesAsync();
                model.Genres = await this.genreService.AllGenresAsync();
                return this.View(model);
            }

            return this.RedirectToAction("All", "Game");
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            List<GameAllViewModel> myGames = new List<GameAllViewModel>();

            string userId = this.User.GetId()!;
            bool isUserPublisher = await this.publisherService.PublisherExistsByUserId(userId);
            myGames.AddRange(await this.gameService.AllByUserIdAsync(userId));


            if (isUserPublisher)
            {
                string? publisherId = await this.publisherService.GetPublisherIdByUserIdAsync(userId);
                myGames.AddRange(await this.gameService.AllByPublisherIdAsync(publisherId!));
            }
            else
            {
                this.TempData[ErrorMessage] = "You must become a publisher and add your games in order to see them!";
                return RedirectToAction("Become", "Publisher");
            }

            return this.View(myGames);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(long id)
        {
            bool gameExists = await gameService.ExistsByIdAsync(id);
            if (!gameExists)
            {
                this.TempData[ErrorMessage] = "Game with the provided id does not exist!";

                return RedirectToAction("All", "Game");
            }

            bool isUserPublisher = await this.publisherService.PublisherExistsByUserId(this.User.GetId()!);
            if (!isUserPublisher && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must become a publisher to edit game info!";

                return this.RedirectToAction("Become", "Publisher");
            }

            string? publisherId = await this.publisherService.GetPublisherIdByUserIdAsync(this.User.GetId()!);
            bool isPublisherOwnGame = await this.gameService.IsPublisherWithIdPublisherOfGameWithIdAsync(id, publisherId!);
            if (!isPublisherOwnGame && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must be the publisher of the game you want to edit!";

                return this.RedirectToAction("Mine", "Game");
            }


            try
            {
            GameAddFromModel model = await this.gameService.GetGameForEditByIdAsync(id);
            model.Categories = await this.categoryService.AllCategoriesAsync();
            model.Genres = await this.genreService.AllGenresAsync();
            return this.View(model);

            }
            catch (Exception)
            {

                return this.GeneralError();
            }


        }

        [HttpPost]
        public async Task<IActionResult> Edit(long id, GameAddFromModel gameAddFromModel)
        {
            if (!ModelState.IsValid)
            {

                gameAddFromModel.Categories = await this.categoryService.AllCategoriesAsync();
                gameAddFromModel.Genres = await this.genreService.AllGenresAsync();


                return this.View(gameAddFromModel);
            }

            bool gameExists = await gameService.ExistsByIdAsync(id);
            if (!gameExists)
            {
                this.TempData[ErrorMessage] = "Game with the provided id does not exist!";

                return RedirectToAction("All", "Game", new { id });
            }

            bool isUserPublisher = await this.publisherService.PublisherExistsByUserId(this.User.GetId()!);
            if (!isUserPublisher && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must become a publisher to edit game info!";

                return this.RedirectToAction("Become", "Publisher");
            }

            string? publisherId = await this.publisherService.GetPublisherIdByUserIdAsync(this.User.GetId()!);
            bool isPublisherOwnGame = await this.gameService.IsPublisherWithIdPublisherOfGameWithIdAsync(id, publisherId!);
            if (!isPublisherOwnGame && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must be the publisher of the game you want to edit!";

                return this.RedirectToAction("Details", "Game");
            }

            try
            {

                await this.gameService.EditGameByIdAndFormModelAsync(gameAddFromModel, id);
            }
            catch (Exception)
            {

                this.ModelState.AddModelError(string.Empty, "Unexpected error occured while trying to add your new game! Please try again later or contact administrator!");

                gameAddFromModel.Categories = await this.categoryService.AllCategoriesAsync();
                gameAddFromModel.Genres = await this.genreService.AllGenresAsync();
                return this.View(gameAddFromModel);
            }
            this.TempData[SuccessMessage] = "House was edited successfully!";
            return this.RedirectToAction("All", "Game");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(long id)
        {
            bool gameExists = await gameService.ExistsByIdAsync(id);
            if (!gameExists)
            {
                this.TempData[ErrorMessage] = "Game with the provided id does not exist!";
                return RedirectToAction("All", "Game");
            }
            bool isUserPublisher = await this.publisherService.PublisherExistsByUserId(this.User.GetId()!);
            if (!isUserPublisher && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must become an agent to edit game info!";
                return this.RedirectToAction("Become", "Publisher");
            }
            string? publisherId = await this.publisherService.GetPublisherIdByUserIdAsync(this.User.GetId()!);
            bool isPublisherOwnGame = await this.gameService.IsPublisherWithIdPublisherOfGameWithIdAsync(id, publisherId!);
            if (!isPublisherOwnGame && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must be the publisher of the game you want to edit!";
                return this.RedirectToAction("Mine", "Game");
            }
            try
            {
                GamePreDeleteDetailsViewModel viewModel = await this.gameService.GetGameForDeleteAsync(id);
                return this.View(viewModel);
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Delete(long id, GamePreDeleteDetailsViewModel model)
        {
            bool gameExists = await gameService.ExistsByIdAsync(id);
            if (!gameExists)
            {
                this.TempData[ErrorMessage] = "Game with the provided id does not exist!";
                return RedirectToAction("All", "Game");
            }
            bool isUserPublisher = await this.publisherService.PublisherExistsByUserId(this.User.GetId()!);
            if (!isUserPublisher && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must become an agent to edit game info!";
                return this.RedirectToAction("Become", "Publisher");
            }
            string? publisherId = await this.publisherService.GetPublisherIdByUserIdAsync(this.User.GetId()!);
            bool isPublisherOwnGame = await this.gameService.IsPublisherWithIdPublisherOfGameWithIdAsync(id, publisherId!);
            if (!isPublisherOwnGame && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must be the publisher of the game you want to edit!";
                return this.RedirectToAction("Mine", "Game");
            }
            try
            {
                await this.gameService.DeleteGameByIdAsync(id);
                this.TempData[WarningMessage] = "The game was successfully delete!";
                return this.RedirectToAction("Mine", "Game");
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostReview(ReviewPostViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { success = false, message = "Invalid review data.", errors = ModelState });
            }

            bool gameExists = await gameService.ExistsByIdAsync(model.GameId);
            if (!gameExists)
            {
                return Json(new { success = false, message = "Game with the provided id does not exist!" });
            }

            string userId = this.User.GetId()!;

            bool reviewPosted = await gameService.PostReview(model.GameId, userId, model);
            if (!reviewPosted)
            {
                return Json(new { success = false, message = "There was an error posting the review. Please try again." });
            }

            return Json(new { success = true, message = "Review posted successfully!" });
        }



        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] =
                            "Unexpected error occurred! Please try again later or contact administrator";

            return RedirectToAction("Index", "Home");
        }


    }
}
