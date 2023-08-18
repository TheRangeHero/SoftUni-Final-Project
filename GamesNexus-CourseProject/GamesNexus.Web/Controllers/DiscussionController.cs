using GamesNexus.Services.Data;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.Infrastructure.Extensions;
using GamesNexus.Web.ViewModels.Comment;
using GamesNexus.Web.ViewModels.Discussion;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static GamesNexus.Common.NotificationMessagesConstants;

namespace GamesNexus.Web.Controllers
{
    public class DiscussionController : BaseController
    {
        private readonly IDiscussionService discussionService;
        private readonly ICommentService commentService;

        public DiscussionController(IDiscussionService _discussionService, ICommentService _commentService)
        {
            this.discussionService = _discussionService;
            this.commentService = _commentService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var discussions = await this.discussionService.AllAsync();
            return View(discussions);
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            bool discussionExists = await this.discussionService.DiscussionExistsByIdAsync(id);
            if (!discussionExists)
            {
                TempData[ErrorMessage] = "Discussion with the provided id does not exist!";

                return RedirectToAction("All", "Discussion");
            }

            try
            {
                DiscussionDetailView view = await this.discussionService.GetDiscussionByIdAsync(id);
                return View(view);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
        [HttpGet]
        public IActionResult Add()
        {
            try
            {
                DiscussionCreateViewModel model = new DiscussionCreateViewModel();
                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(DiscussionCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                string userId = this.User.GetId()!;
                await this.discussionService.CreateAsync(model, userId);

                this.TempData[SuccessMessage] = "Added successfully!";
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occured while trying to add your new discussion! Please try again later or contact administrator!");

                return this.View(model);

            }
            return this.RedirectToAction("All", "Discussion");
        }
        [HttpPost]
        public async Task<IActionResult> PostComment(CreateCommentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { success = false });
            }

            string userId = User.GetId()!;


            var addedCommentId = await commentService.AddCommentToDiscussionAsync(model.DiscussionId, userId, model);

            if (addedCommentId != null)
            {
                // Using directly the logged user's username without accessing it from the comment
                var username = User.Identity?.Name;

                return Json(new
                {
                    success = true,
                    comment = new
                    {
                        content = model.Content,
                        publishedBy = username,
                        postedOn = DateTime.Now.ToString("dd.MM.yyyy")
                    }
                });
            }
            else
            {
                return Json(new { success = false });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            bool discussionExist = await discussionService.DiscussionExistsByIdAsync(id);
            if (!discussionExist)
            {
                return Json(new { success = false, message = "Discussion not found." });
            }

            var currentUserId = this.User.GetId()!;

            bool isUsersOwnNews = await this.discussionService.IsUserWithIdPublisherOfDiscussionWithIdAsync(id, currentUserId!);
            if (!isUsersOwnNews && !this.User.IsAdmin())
            {
                this.TempData[ErrorMessage] = "You must be the creator of the discussion in order to delete it!";
                return this.RedirectToAction("Mine", "News");
            }
            try
            {
                await this.discussionService.DeleteDiscussionByIdAsync(id);
                return Json(new { success = true });
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
