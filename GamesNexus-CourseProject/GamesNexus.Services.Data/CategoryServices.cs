using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Category;
using GamesNexus.Web.ViewModels.Game;
using Microsoft.EntityFrameworkCore;

namespace GamesNexus.Services.Data
{
    public class CategoryServices : ICategoryService
    {
        private readonly IRepository repository;
        public CategoryServices(IRepository _repository)
        {
            this.repository = _repository;
        }

        public async Task<IEnumerable<GameSelectCategoryFormModel>> AllCategoriesAsync()
        {
            IEnumerable<GameSelectCategoryFormModel> allCategories = await this.repository.AllReadonly<Category>()
                .AsNoTracking()
                .Select(c => new GameSelectCategoryFormModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToArrayAsync();

            return allCategories;
        }

        public async Task CreateAsync(CreateCategoryViewModel formModel)
        {
            Category category = new Category()
            {
                Name = formModel.Name,
            };

            await this.repository.AddAsync(category);
            await this.repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {
            bool result = await this.repository.AllReadonly<Category>()
                .AnyAsync(c => c.Id == id);

            return result;
        }

        public async Task<bool> ExistsByNameAsync(string name)
        {
            return await this.repository.AllReadonly<Category>()
                .AnyAsync(c=>c.Name.ToLower() == name.ToLower());
        }
    }
}
