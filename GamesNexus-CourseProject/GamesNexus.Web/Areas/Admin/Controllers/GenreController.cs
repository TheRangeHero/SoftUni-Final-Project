using GamesNexus.Services.Data;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Genre;
using Microsoft.AspNetCore.Mvc;

namespace GamesNexus.Web.Areas.Admin.Controllers
{
    public class GenreController : BaseAdminController
    {
        private readonly IGenreService genreService;

        public GenreController(IGenreService _genreService)
        {
            this.genreService = _genreService;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateGenreViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if ( await genreService.ExistsByNameAsync(model.Name))
            {
                ModelState.AddModelError(string.Empty, "This genre already exists.");
                return View(model);
            }

            await genreService.CreateAsync(model);
            return RedirectToAction("Index", "Home"); 
        }
    }
}
