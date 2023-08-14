using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Data.Models.Enums;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Game;
using GamesNexus.Web.ViewModels.Review;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Globalization;



namespace GamesNexus.Services.Data
{
    public class GameServices : IGameService
    {
        private readonly IRepository repository;
        private readonly IGenreService genreService;
        private readonly ICategoryService categoryService;


        public GameServices(IRepository _repository, IGenreService _genreService, ICategoryService _categoryService)
        {
            repository = _repository;
            this.genreService = _genreService;
            this.categoryService = _categoryService;
        }

        public async Task<IEnumerable<GameAllViewModel>> AllAsync()
        {
            IEnumerable<GameAllViewModel> allGames = await repository.AllReadonly<Game>()
                .Where(g => g.IsActive)
                .Select(g => new GameAllViewModel
                {
                    Id = g.Id,
                    Title = g.Title,
                    Image = g.Image1URL,
                    Price = g.Price,

                }).ToArrayAsync();

            return allGames;

        }
        public async Task<bool> ExistsByIdAsync(long Id)
        {
            bool result = await repository.AllReadonly<Game>()
                .Where(g => g.IsActive)
                .AnyAsync(g => g.Id == Id);

            return result;

        }
        public async Task<GameDetailViewModel> GameDetailsById(int Id)
        {
            Game game = await repository.AllReadonly<Game>()
                  .Include(g => g.Publisher)
                  .Include(g => g.GamesCategories).ThenInclude(g => g.Category)
                  .Include(g => g.GamesGenres).ThenInclude(g => g.Genre)
                  .Include(g => g.Reviews)
                  .Include(u => u.ApplicationUser)
                  .FirstAsync(g => g.Id == Id);

            return new GameDetailViewModel
            {
                Id = game.Id,
                Title = game.Title,
                Description = game.Description,
                Price = game.Price,
                ReleaseDate = game.ReleaseDate.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                Developer = game.Developer,
                Publisher = game.Publisher.CompanyName,
                Genres = game.GamesGenres.Select(gg => gg.Genre.Name).ToList(),
                Categories = game.GamesCategories.Select(gc => gc.Category.Name).ToList(),
                OS = game.OS,
                CPU = game.CPU,
                RAM = game.RAM,
                GPU = game.GPU,
                Storage = game.Storage,
                AdditionalNotes = game.AdditionalNotes,
                Image1 = game.Image1URL,
                Image2 = string.IsNullOrWhiteSpace(game.Image2URL) ? null : game.Image2URL,
                Image3 = string.IsNullOrWhiteSpace(game.Image3URL) ? null : game.Image3URL,
                Video = game.VideoURL,
                Reviews = game.Reviews.Select(review => new ReviewAllViewModel
                {
                    Rating = Enum.GetName(typeof(RatingOption), review.Rating),
                    Comment = review.Comment,
                    PostedOn = review.PostedOn.ToString("HH:mm dd.MM.yyyy"),
                }).ToList()
            };
        }

        public async Task<IEnumerable<GameIndexViewModel>> LastFiveGamesIndexAsync()
        {
            IEnumerable<GameIndexViewModel> allGames = await repository.AllReadonly<Game>()
                .Include(g => g.GamesGenres)
                .Where(g => g.IsActive)
                .OrderByDescending(g => g.ReleaseDate)
                .Take(5)
                .Select(g => new GameIndexViewModel
                {
                    Id = g.Id,
                    Title = g.Title,
                    ImageUrl = g.Image1URL,
                    Genres = g.GamesGenres.Select(gg => gg.Genre.Name).ToList(),

                }).ToArrayAsync();

            return allGames;
        }

        public async Task CreateAsync(GameAddFromModel formModel, string publisherId)
        {

            Game newGame = new Game()
            {
                Id = formModel.Id,
                Title = formModel.Title,
                Description = formModel.Description,
                Price = formModel.Price,
                Developer = formModel.Developer,
                OS = formModel.OS,
                CPU = formModel.CPU,
                RAM = formModel.RAM,
                GPU = formModel.GPU,
                Storage = formModel.Storage,
                Image1URL = formModel.Image1,
                Image2URL = formModel.Image2,
                Image3URL = formModel.Image3,
                VideoURL = formModel.Video,
                PublisherId = Guid.Parse(publisherId)
            };

            await this.repository.AddAsync(newGame);
            await this.repository.SaveChangesAsync();

            List<GameGenre> gameGenres = new List<GameGenre>();
            foreach (var genreId in formModel.SelectedGenreIds)
            {
                var gameGenre = new GameGenre
                {
                    GameId = newGame.Id,
                    GenreId = genreId
                };
                gameGenres.Add(gameGenre);

            }
            await this.repository.AddRangeAsync(gameGenres);
            await this.repository.SaveChangesAsync();

            List<GameCategory> gameCategories = new List<GameCategory>();
            foreach (var categoryId in formModel.SelectedCategoryIds)
            {
                var gameCategory = new GameCategory
                {
                    GameId = newGame.Id,
                    CategoryId = categoryId
                };
                gameCategories.Add(gameCategory);


            }
            await repository.AddRangeAsync(gameCategories);
            await this.repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<GameAllViewModel>> AllByUserIdAsync(string agentId)
        {
            IEnumerable<GameAllViewModel> allUsersHouses = await this.repository.AllReadonly<Game>()
               .Include(u => u.ApplicationUser)
               .Where(g => g.IsActive)
               .Where(g => g.ApplicationUserId.ToString() == agentId)
               .Select(g => new GameAllViewModel()
               {
                   Id = g.Id,
                   Title = g.Title,
                   Image = g.Image1URL,
                   Price = g.Price,
               })
               .ToArrayAsync();

            return allUsersHouses;
        }

        public async Task<IEnumerable<GameAllViewModel>> AllByPublisherIdAsync(string publisherId)
        {
            IEnumerable<GameAllViewModel> allPublisherHouses = await this.repository.AllReadonly<Game>()
               .Include(p => p.Publisher)
               .Where(g => g.IsActive)
               .Where(g => g.PublisherId.ToString() == publisherId)
               .Select(g => new GameAllViewModel()
               {
                   Id = g.Id,
                   Title = g.Title,
                   Image = g.Image1URL,
                   Price = g.Price,
               })
               .ToArrayAsync();

            return allPublisherHouses;
        }

        public async Task<GameAddFromModel> GetGameForEditByIdAsync(long id)
        {
            Game game = await repository.AllReadonly<Game>()

                 .Include(g => g.GamesCategories).ThenInclude(g => g.Category)
                 .Include(g => g.GamesGenres).ThenInclude(g => g.Genre)
                 .Include(g => g.Reviews)
                 .FirstAsync(g => g.Id == id);

            return new GameAddFromModel
            {
                Title = game.Title,
                Description = game.Description,
                Price = game.Price,
                Developer = game.Developer,
                OS = game.OS,
                CPU = game.CPU,
                RAM = game.RAM,
                GPU = game.GPU,
                Storage = game.Storage,
                Image1 = game.Image1URL,
                Image2 = game.Image2URL,
                Image3 = game.Image3URL,
                Video = game.VideoURL,
                SelectedGenreIds = game.GamesGenres.Select(g => g.GenreId).ToList(),
                SelectedCategoryIds = game.GamesCategories.Select(c => c.CategoryId).ToList()

            };
        }


        public async Task EditGameByIdAndFormModel(GameAddFromModel formModel, long id)
        {
            Game game = await this.repository.All<Game>()
                 .Include(g => g.GamesGenres)
                 .Include(g => g.GamesCategories)
                 .FirstAsync(g => g.Id == id);
    
            game.Title = formModel.Title;
            game.Description = formModel.Description;
            game.Price = formModel.Price;
            game.Developer = formModel.Developer;
            game.OS = formModel.OS;
            game.CPU = formModel.CPU;
            game.RAM = formModel.RAM;
            game.GPU = formModel.GPU;
            game.AdditionalNotes = formModel.AdditionalNotes;
            game.Storage = formModel.Storage;
            game.Image1URL = formModel.Image1;
            game.Image2URL = formModel.Image2;
            game.Image3URL = formModel.Image3;
            game.VideoURL = formModel.Video;
            await repository.SaveChangesAsync();

            repository.DeleteRange(game.GamesGenres);
            repository.DeleteRange(game.GamesCategories);

            await repository.SaveChangesAsync();

            // Create and add new relations for genres
            foreach (var genreId in formModel.SelectedGenreIds)
            {
                game.GamesGenres.Add(new GameGenre
                {
                    GameId = game.Id,
                    GenreId = genreId
                });
            }

            // Create and add new relations for categories
            foreach (var categoryId in formModel.SelectedCategoryIds)
            {
                game.GamesCategories.Add(new GameCategory
                {
                    GameId = game.Id,
                    CategoryId = categoryId
                });
            }

            // Save the updated game entity
            await repository.SaveChangesAsync();
        }
        public async Task<bool> IsPublisherWithIdPublisherOfGameWithIdAsync(long gameId, string publisherId)
        {
            Game game = await this.repository.AllReadonly<Game>()
                .Where(g => g.IsActive)
                .FirstAsync(g => g.Id == gameId);

            return game.PublisherId.ToString() == publisherId;
        }
    }
}



