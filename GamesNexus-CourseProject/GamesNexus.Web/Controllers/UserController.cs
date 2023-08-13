using GamesNexus.Data.Models;
using GamesNexus.Web.Infrastructure.Extensions;
using GamesNexus.Web.ViewModels.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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

        [HttpGet]
        public async Task<IActionResult> EditProfile()
        {
            //var user = await userManager.GetUserAsync(User);
            string? userId = User.GetId();
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return this.View();
            }

            var editMV = new EditProfileModel()
            {
                Username = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                City = user.City,
                Country = user.Country,

            };

            return View(editMV);

        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(EditProfileModel model)
        {

            //var user = await userManager.GetUserAsync(User);
            string? userId = User.GetId();
            var user = await userManager.FindByIdAsync(userId);


            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit profile");
                return this.View(model);
            }
             

            if (user == null)
            {
                return View("Error");
            }

            try
            {

                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.City = model.City;
                user.Country = model.Country;
                user.UserName = model.Username;

                 var result = await this.userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }

            }
            catch (Exception)
            {

                ModelState.AddModelError("", "An error occurred while updating the profile.");
                return View(model);
            }
        }

    }
}
