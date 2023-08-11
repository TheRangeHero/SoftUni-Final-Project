using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.Infrastructure.Extensions;
using GamesNexus.Web.ViewModels.Publisher;
using Microsoft.AspNetCore.Mvc;

using static GamesNexus.Common.NotificationMessagesConstants;

namespace GamesNexus.Web.Controllers
{
    public class PublisherController : BaseController
    {
        private readonly IPublisherService publisherService;

        public PublisherController(IPublisherService _publisherService)
        {
            this.publisherService = _publisherService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            string? userId = this.User.GetId();

            bool isAgent = await this.publisherService.PublisherExistsByUserId(userId);

            if (isAgent)
            {
                return BadRequest("You are already a Publisher!");
            }

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomePublisherFormModel model)
        {
            string? userId = this.User.GetId();

            bool isAgent = await this.publisherService.PublisherExistsByUserId(userId);

            if (isAgent)
            {
                return BadRequest("You are already a Publisher!");
            }

            bool isBusinessEmailTaken = await this.publisherService.PublisherExistsByBusinessEmailAsync(model.BusinessEmail);
            if (isBusinessEmailTaken)
            {
                ModelState.AddModelError(nameof(model.BusinessEmail), "Publisher provided business email already exists!");
            }

            bool isCompanyNameTaken = await this.publisherService.PublisherExistsByBusinessEmailAsync(model.CompanyName);
            if (isBusinessEmailTaken)
            {
                ModelState.AddModelError(nameof(model.CompanyName), "Publisher provided company name already exists!");
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }


            try
            {
            await this.publisherService.Create(userId, model);

            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("All", "Game");
        }
    }
}
