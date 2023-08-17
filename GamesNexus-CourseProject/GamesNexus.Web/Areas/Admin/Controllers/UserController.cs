using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.User;
using Microsoft.AspNetCore.Mvc;

namespace GamesNexus.Web.Areas.Admin.Controllers
{
    public class UserController : BaseAdminController
    {
        private readonly IUserService userService;

        public UserController(IUserService _userService)
        {
            this.userService = _userService;
        }

        [Route("User/All")]
        public async Task<IActionResult> All()
        {
            IEnumerable<UserViewModel> viewModels = await this.userService.AllAsync();

            return View(viewModels);
        }
    }
}
