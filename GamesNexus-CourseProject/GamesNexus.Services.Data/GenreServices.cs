using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Genre;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<bool> ExistsByIdAsync(int id)
        {
            bool result = await this.repository.AllReadonly<Genre>()
                .AnyAsync(g=>g.Id == id);

            return result;
        }
    }
}
