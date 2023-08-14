using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Game;
using GamesNexus.Web.ViewModels.News;
using Microsoft.EntityFrameworkCore;
using System.Globalization;



namespace GamesNexus.Services.Data
{
    public class NewsServices : INewsService
    {
        private readonly IRepository repository;

        public NewsServices(IRepository _repository)
        {
            this.repository = _repository;
        }

        public async Task<IEnumerable<NewsAllViewModel>> AllAsync()
        {
            IEnumerable<NewsAllViewModel> allNews = await repository.AllReadonly<News>()
                .Where(n => n.IsActive)
                .Include(p => p.Publisher)
                .Select(n => new NewsAllViewModel
                {
                    Id = n.Id,
                    Title = n.Title,
                    Content = n.Content,
                    PublishedOn = n.PublishedOn.ToString("MM/dd/yyyy"),
                    PublisherName = n.Publisher.ApplicationUser.UserName

                }).ToArrayAsync();

            return allNews;
        }

        public async Task<NewsAllViewModel> NewsFullById(int Id)
        {

            News news = await this.repository.AllReadonly<News>()
                .Include(p => p.Publisher)
                .ThenInclude(p => p.ApplicationUser)
                .FirstAsync(n => n.Id == Id);

            return new NewsAllViewModel
            {
                Id = news.Id,
                Title = news.Title,
                Content = news.Content,
                PublishedOn = news.PublishedOn.ToString("MM/dd/yyyy"),
                PublisherName = news.Publisher.ApplicationUser.UserName

            };

        }

        public async Task<IEnumerable<NewsIndexViewModel>> LastFiveNewsIndexAsync()
        {
            IEnumerable<NewsIndexViewModel> news = await repository.AllReadonly<News>()
                .Where(n => n.IsActive)
                .OrderByDescending(n => n.PublishedOn)
                .Take(6)
                .Select(n => new NewsIndexViewModel
                {
                    Id = n.Id,
                    Title = n.Title,
                    PublishedOn = n.PublishedOn.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture)
                })
                .ToArrayAsync();

            return news;
        }

        public async Task<bool> NewsExistsByIdAsync(long Id)
        {
            bool result = await repository.AllReadonly<News>()
                .Where(g => g.IsActive)
                .AnyAsync(g => g.Id == Id);

            return result;
        }

        public async Task CreateAsync(NewsAddFormModel formModel, string publisherId)
        {
            News news = new News()
            {
                Id = formModel.Id,
                Title = formModel.Title,
                Content = formModel.Content,
                PublisherId = Guid.Parse(publisherId)
            };

            await this.repository.AddAsync(news);
            await this.repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<NewsAllViewModel>> AllByPublisherIdAsync(string userId)
        {
            IEnumerable<NewsAllViewModel> allUserNews = await this.repository.AllReadonly<News>()
              .Include(n => n.Publisher)
              .ThenInclude(n => n.ApplicationUser)
              .Where(n => n.IsActive)
               .Where(n => n.Publisher.ApplicationUser.Id.ToString() == userId)
               .Select(n => new NewsAllViewModel
               {
                   Id = n.Id,
                   Title = n.Title,
                   Content = n.Content,
                   PublishedOn = n.PublishedOn.ToString("MM/dd/yyyy"),
                   PublisherName = n.Publisher.ApplicationUser.UserName
               })
              .ToArrayAsync();

            return allUserNews;
        }

        public async Task<bool> ExistsByIdAsync(int Id)
        {
            bool result = await repository.AllReadonly<News>()
                .Where(g => g.IsActive)
                .AnyAsync(g => g.Id == Id);

            return result;
        }

        public async Task<bool> IsPublisherWithIdPublisherOfNewsWithIdAsync(int gameId, string publisherId)
        {
            News news = await this.repository.AllReadonly<News>()
                .Where(g => g.IsActive)
                .FirstAsync(g => g.Id == gameId);

            return news.PublisherId.ToString() == publisherId;
        }

        public async Task<NewsAddFormModel> GetNewsForEditByIdAsync(int id)
        {
            News news = await repository.AllReadonly<News>()
                .FirstAsync(g => g.Id == id);

            return new NewsAddFormModel()
            {
                Id = news.Id,
                Title = news.Title,
                Content = news.Content
            };
        }

        public async Task EditNewsByIdAndFormModelAsync(NewsAddFormModel formModel, int id)
        {
            News news = await this.repository.All<News>()
                 .FirstAsync(g => g.Id == id);

            news.Title = formModel.Title;
            news.Content = formModel.Content;

            await this.repository.SaveChangesAsync();
        }

        public async Task<NewsAllViewModel> GetNewsForDeleteAsync(int id)
        {
            News news = await this.repository.All<News>()
                .Include(n => n.Publisher)
                .ThenInclude(n => n.ApplicationUser)
                .FirstAsync(n => n.Id == id);

            return new NewsAllViewModel
            {
                Title = news.Title,
                Content = news.Content,
                PublishedOn = news.PublishedOn.ToString("MM/dd/yyyy"),
                PublisherName = news.Publisher.ApplicationUser.UserName

            };
        }

        public async Task DeleteNewsByIdAsync(int id)
        {
            News newsToDelete = await this.repository.GetByIdAsync<News>(id);
            newsToDelete.IsActive = false;
            await this.repository.SaveChangesAsync();
        }
    }
}
