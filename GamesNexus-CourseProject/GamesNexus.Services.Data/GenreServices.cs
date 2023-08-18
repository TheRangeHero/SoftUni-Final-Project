using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Genre;
using Microsoft.EntityFrameworkCore;

namespace GamesNexus.Services.Data
{
    public class GenreServices : IGenreService
    {
        private readonly IRepository repository;

        public GenreServices(IRepository _repository)
        {
            this.repository = _repository;
        }

        public async Task<IEnumerable<GameSelectGenreFormModel>> AllGenresAsync()
        {
            IEnumerable<GameSelectGenreFormModel> allGerens = await this.repository.AllReadonly<Genre>()
                .AsNoTracking()
                .Select(g => new GameSelectGenreFormModel()
                {
                    Id = g.Id,
                    Name = g.Name,
                })
                .ToArrayAsync();

            return allGerens;
        }

        public async Task CreateAsync(CreateGenreViewModel formModel)
        {
            Genre genre  = new Genre()
            {
                Name = formModel.Name,
            };

            await this.repository.AddAsync(genre);
            await this.repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {
            bool result = await this.repository.AllReadonly<Genre>()
                .AnyAsync(g=>g.Id == id);

            return result;
        }

        public async Task<bool> ExistsByNameAsync(string name)
        {
            return await this.repository.AllReadonly<Genre>()
                .AllAsync(g=>g.Name.ToLower() == name.ToLower());
        }
    }
}
