using GamesNexus.Data.Models;
using GamesNexus.Web.ViewModels.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

using static GamesNexus.Common.NotificationMessagesConstants;

namespace GamesNexus.Web.Controllers
{
    public class UserController : BaseController
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserStore<ApplicationUser> userStore;

        public UserController(SignInManager<ApplicationUser> _signInManager,
                               UserManager<ApplicationUser> _userManager,
                               IUserStore<ApplicationUser> _userStore)
        {
            this.signInManager = _signInManager;
            this.userManager = _userManager;
            this.userStore = _userStore;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            ApplicationUser applicationUser = new ApplicationUser()
            {
                //UserName = model.UserName,
                //Email = model.Email,
            };

            await this.userManager.SetEmailAsync(applicationUser, model.Email);
            await this.userManager.SetUserNameAsync(applicationUser, model.Username);
            IdentityResult result =
                await this.userManager.CreateAsync(applicationUser, model.Password);


            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }
            await this.signInManager.SignInAsync(applicationUser, false);

            return this.RedirectToAction("Index", "Home");


        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Login(string? returnUrl = null)
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            LoginFormModel model = new LoginFormModel()
            {
                ReturnUrl = returnUrl,
            };

            return this.View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginFormModel model)
        {

            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            var result =
                await this.signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);

            if (!result.Succeeded)
            {
                this.TempData[ErrorMessage] = "There was an error while logging you in! Please try again later or contact an administrator.";

                return this.View(model);
            }

            return this.Redirect(model.ReturnUrl ?? "/Home/Index");
        }

    }
}
