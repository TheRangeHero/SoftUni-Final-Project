using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Game;
using GamesNexus.Web.ViewModels.SystemRequirement;
using Microsoft.EntityFrameworkCore;


namespace GamesNexus.Services.Data
{
    public class GameServices : IGameService
    {
        private readonly IRepository repository;


        public GameServices(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<GameAllViewModel>> AllAsync()
        {
            IEnumerable<GameAllViewModel> allGames = await repository.AllReadonly<Game>()
                .Include(g => g.Images)
                .Select(g => new GameAllViewModel
                {
                    Id = g.Id,
                    Title = g.Title,
                    Image = g.Images.FirstOrDefault().ImageUrl,
                    Price = g.Price,

                }).ToArrayAsync();

            return allGames;

        }

        public async Task<bool> ExistsByIdAsync(int Id)
        {
            bool result = await repository.AllReadonly<Game>()
                .AnyAsync(g=>g.Id == Id);

            return result;
                
        }

        public async Task<GameDetailViewModel> GameDetailsById(int Id)
        {
            Game game = await repository.AllReadonly<Game>()
                  .Include(g => g.SystemRequirement)
                  .Include(g => g.Videos)
                  .Include(g => g.Images)
                  .Include(g => g.Publisher)
                  .Include(g => g.GamesCategories).ThenInclude(g=>g.Category)
                  .Include(g => g.GamesGenres).ThenInclude(g=>g.Genre)
                  .FirstAsync(g => g.Id == Id);

            return new GameDetailViewModel
            {
                Id = game.Id,
                Description = game.Description,
                Price = game.Price,
                ReleaseDate = game.ReleaseDate,
                Developer = game.Developer,
                Publisher = game.Publisher.CompanyName,
                Genres = game.GamesGenres.Select(gg => gg.Genre.Name).ToList(),
                Categories = game.GamesCategories.Select(gc => gc.Category.Name).ToList(),
                SystemRequirements = new SystemRequirementAllViewModel
                {
                    OS = game.SystemRequirement.OS,
                    CPU = game.SystemRequirement.CPU,
                    RAM = game.SystemRequirement.RAM,
                    GPU = game.SystemRequirement.GPU,
                    Storage = game.SystemRequirement.Storage,
                    AdditionalNotes = game.SystemRequirement.AdditionalNotes
                },
                Images = game.Images.Select(img => img.ImageUrl).ToList(),
                Videos = game.Videos.Select(vid => vid.VideoUrl).ToList()
            };
        }
    }
}



