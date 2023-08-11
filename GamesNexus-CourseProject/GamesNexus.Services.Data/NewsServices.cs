using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.News;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Services.Data
{
    public class NewsServices : INewsService
    {
        private readonly IRepository repository;

        public NewsServices(IRepository _repository)
        {
            this.repository = _repository;
        }
        public async Task<IEnumerable<NewsIndexViewModel>> LastFiveNewsIndexAsync()
        {
            IEnumerable<NewsIndexViewModel> news = await repository.AllReadonly<News>()
                .OrderByDescending(n => n.PublishedOn)
                .Take(5)
                .Select(n => new NewsIndexViewModel
                {
                    Id = n.Id,
                    Title = n.Title,
                    Content = n.Content,
                    PublishedOn = n.PublishedOn.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture)
                })
                .ToArrayAsync();

            return news;
        }
    }
}
