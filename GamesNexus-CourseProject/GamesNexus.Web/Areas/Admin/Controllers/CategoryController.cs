using GamesNexus.Services.Data;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Category;
using Microsoft.AspNetCore.Mvc;

namespace GamesNexus.Web.Areas.Admin.Controllers
{
    public class CategoryController : BaseAdminController
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService _categoryService)
        {

            this.categoryService = _categoryService;

        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateCategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await categoryService.ExistsByNameAsync(model.Name))
            {
                ModelState.AddModelError(string.Empty, "This genre already exists.");
                return View(model);
            }

            await categoryService.CreateAsync(model);
            return RedirectToAction("Index", "Home");
        }
    }
}
