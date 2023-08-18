using GamesNexus.Services.Data;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.Infrastructure.Extensions;
using GamesNexus.Web.ViewModels.Game;
using GamesNexus.Web.ViewModels.News;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static GamesNexus.Common.NotificationMessagesConstants;

namespace GamesNexus.Web.Controllers
{
    public class NewsController : BaseController
    {
        private readonly INewsService newsService;
        private readonly IPublisherService publisherService;

        public NewsController(INewsService _newsService, IPublisherService _publisherService)
        {
            this.newsService = _newsService;
            this.publisherService = _publisherService;

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            IEnumerable<NewsAllViewModel> allGames = await newsService.AllAsync();
            return View(allGames);
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int Id)
        {
            bool newsExists = await newsService.NewsExistsByIdAsync(Id);
            if (!newsExists)
            {
                TempData[ErrorMessage] = "News with the provided id does not exist!";

                return RedirectToAction("All", "News");
            }

            try
            {
                NewsAllViewModel viewModel = await newsService.NewsFullById(Id);
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
                this.TempData[ErrorMessage] = "You must become a publisher in order to publish a news!";
                return RedirectToAction("Become", "Publisher");
            }


            try
            {

                NewsAddFormModel model = new NewsAddFormModel();


                return View(model);
            }
            catch (Exception)
            {

                return this.GeneralError();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add (NewsAddFormModel model)
        {
            bool isPublisher = await this.publisherService.PublisherExistsByUserId(this.User.GetId()!);

            if (!isPublisher)
            {
                this.TempData[ErrorMessage] = "You must become a publisher in order to write news!";
                return RedirectToAction("Become", "Publisher");
            }

            if (!ModelState.IsValid)
            {



                return this.View(model);
            }

            try
            {
                string? publisherId = await this.publisherService.GetPublisherIdByUserIdAsync(this.User.GetId()!);
                await this.newsService.CreateAsync(model, publisherId!);

                this.TempData[SuccessMessage] = "Added successfully!";
            }
            catch (Exception)
            {

                this.ModelState.AddModelError(string.Empty, "Unexpected error occured while trying to add your news! Please try again later or contact administrator!");

                return this.View(model);
            }

            return this.RedirectToAction("All", "News");
        }
        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            List<NewsAllViewModel> myNews = new List<NewsAllViewModel>();

            string userId = this.User.GetId()!;
            bool isUserPublisher = await this.publisherService.PublisherExistsByUserId(userId);
            myNews.AddRange(await this.newsService.AllByPublisherIdAsync(userId));

            if (isUserPublisher)
            {
                string? publisherId = await this.publisherService.GetPublisherIdByUserIdAsync(userId);
                myNews.AddRange(await this.newsService.AllByPublisherIdAsync(publisherId!));
            }
            else
            {
                this.TempData[ErrorMessage] = "You must become a publisher and write your own news in order to see them!";
                return RedirectToAction("Become", "Publisher");
            }

            return this.View(myNews);
        }
        [HttpGet]
        public async Task<IActionResult> Edit (int id)
        {
            bool gameExists = await newsService.NewsExistsByIdAsync(id);
            if (!gameExists)
            {
                this.TempData[ErrorMessage] = "News with the provided Id does not exist!";

                return RedirectToAction("All", "News");
            }

            bool isUserPublisher = await this.publisherService.PublisherExistsByUserId(this.User.GetId()!);
            if (!isUserPublisher && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must become an publisher to edit news!";

                return this.RedirectToAction("Become", "Publisher");
            }

            string? publisherId = await this.publisherService.GetPublisherIdByUserIdAsync(this.User.GetId()!);
            bool isPublisherOwnNews = await this.newsService.IsPublisherWithIdPublisherOfNewsWithIdAsync(id, publisherId!);
            if (!isPublisherOwnNews && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must be the publisher of this news in order to edit it!";

                return this.RedirectToAction("Mine", "News");
            }


            try
            {
                NewsAddFormModel model = await this.newsService.GetNewsForEditByIdAsync(id);
                return this.View(model);

            }
            catch (Exception)
            {

                return this.GeneralError();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit (int id, NewsAddFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);           
            }

            bool gameExists = await newsService.NewsExistsByIdAsync(id);
            if (!gameExists)
            {
                this.TempData[ErrorMessage] = "News with the provided id does not exist!";

                return RedirectToAction("All", "News", new { id });
            }

            bool isUserPublisher = await this.publisherService.PublisherExistsByUserId(this.User.GetId()!);
            if (!isUserPublisher && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must become an publisher to edit news info!";

                return this.RedirectToAction("Become", "Publisher");
            }

            string? publisherId = await this.publisherService.GetPublisherIdByUserIdAsync(this.User.GetId()!);
            bool isPublisherOwnNews = await this.newsService.IsPublisherWithIdPublisherOfNewsWithIdAsync(id, publisherId!);
            if (!isPublisherOwnNews && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must be the publisher of this news if you want to edit!";

                return this.RedirectToAction("Details", "News");
            }

            try
            {

                await this.newsService.EditNewsByIdAndFormModelAsync(model, id);
            }
            catch (Exception)
            {

                this.ModelState.AddModelError(string.Empty, "Unexpected error occured while trying to add your new news! Please try again later or contact administrator!");

               
                return this.View(model);
            }
            this.TempData[SuccessMessage] = "Edited successfully!";
            return this.RedirectToAction("Mine", "News");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            bool newsExists = await newsService.NewsExistsByIdAsync(id);
            if (!newsExists)
            {
                this.TempData[ErrorMessage] = "News with the provided id does not exist!";
                return RedirectToAction("All", "News");
            }
            bool isUserPublisher = await this.publisherService.PublisherExistsByUserId(this.User.GetId()!);
            if (!isUserPublisher && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must become an publisher to edit news!";
                return this.RedirectToAction("Become", "Publisher");
            }
            string? publisherId = await this.publisherService.GetPublisherIdByUserIdAsync(this.User.GetId()!);
            bool isPublisherOwnNews = await this.newsService.IsPublisherWithIdPublisherOfNewsWithIdAsync(id, publisherId!);
            if (!isPublisherOwnNews && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must be the publisher of this news if you want to edit!";
                return this.RedirectToAction("Mine", "News");
            }
            try
            {
                NewsAllViewModel viewModel = await this.newsService.GetNewsForDeleteAsync(id);
                return this.View(viewModel);
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Delete (int id, NewsAllViewModel model)
        {
            bool newsExists = await newsService.NewsExistsByIdAsync(id);
            if (!newsExists)
            {
                this.TempData[ErrorMessage] = "News with the provided id does not exist!";
                return RedirectToAction("All", "News");
            }
            bool isUserPublisher = await this.publisherService.PublisherExistsByUserId(this.User.GetId()!);
            if (!isUserPublisher && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must become an publisher to delete news!";
                return this.RedirectToAction("Become", "Publisher");
            }
            string? publisherId = await this.publisherService.GetPublisherIdByUserIdAsync(this.User.GetId()!);
            bool isPublisherOwnNews = await this.newsService.IsPublisherWithIdPublisherOfNewsWithIdAsync(id, publisherId!);
            if (!isPublisherOwnNews && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must be the publisher of the news in order to delete it!";
                return this.RedirectToAction("Mine", "News");
            }
            try
            {
                await this.newsService.DeleteNewsByIdAsync(id);
                this.TempData[WarningMessage] = "The News was successfully delete!";
                return this.RedirectToAction("Mine", "News");
            }
            catch (Exception)
            {
                return this.GeneralError();
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
