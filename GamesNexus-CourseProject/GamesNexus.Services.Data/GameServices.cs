using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Data.Models.Enums;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Game;
using GamesNexus.Web.ViewModels.Review;
using Microsoft.EntityFrameworkCore;
using System.Globalization;



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
                .AnyAsync(g => g.Id == Id);

            return result;

        }
        public async Task<GameDetailViewModel> GameDetailsById(int Id)
        {
            Game game = await repository.AllReadonly<Game>()
                  .Include(g => g.Videos)
                  .Include(g => g.Images)
                  .Include(g => g.Publisher)
                  .Include(g => g.GamesCategories).ThenInclude(g => g.Category)
                  .Include(g => g.GamesGenres).ThenInclude(g => g.Genre)
                  .Include(g => g.Reviews)
                  .Include(u => u.ApplicationUser)
                  .FirstAsync(g => g.Id == Id);

            return new GameDetailViewModel
            {
                Id = game.Id,
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
                Images = game.Images.Select(img => img.ImageUrl).ToList(),
                Videos = game.Videos.Select(vid => vid.VideoUrl).ToList(),
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
                .Include(g => g.Images)
                .Include(g => g.GamesGenres)
                .OrderByDescending(g => g.ReleaseDate)
                .Take(5)
                .Select(g => new GameIndexViewModel
                {
                    Id = g.Id,
                    Title = g.Title,
                    ImageUrl = g.Images.FirstOrDefault().ImageUrl,
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
                Images = formModel.ImageUrls.Select(url => new GameImage { ImageUrl = url }).ToList(),
                Videos = formModel.VideoUrls.Select(url => new GameVideo { VideoUrl = url }).ToList(),

                GamesCategories = formModel.Categories.Select(category => new GameCategory
                {
                    GameId = formModel.Id,
                    CategoryId = category.Id,

                })
                                        .ToList(),

                GamesGenres = formModel.Genres.Select(genre => new GameGenre
                {
                    GameId = formModel.Id,
                    GenreId = genre.Id
                })
                                    .ToList(),
                PublisherId = Guid.Parse(publisherId)
            };

            await this.repository.AddAsync(newGame);
            await this.repository.SaveChangesAsync();

        }
    }
}



