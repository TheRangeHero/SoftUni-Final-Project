using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Publisher;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Services.Data
{
    public class PublisherServices : IPublisherService
    {
        private readonly IRepository repository;

        public PublisherServices(IRepository _repository)
        {
            this.repository = _repository;
        }


        public async Task<bool> PublisherExistsByBusinessEmailAsync(string email)
        {
            bool result = await this.repository.All<Publisher>()
                 .AnyAsync(p => p.BusinessEmail == email);

            return result;
        }

        public async Task<bool> PublisherExistsByCompanyNameAsync(string company)
        {
            bool result = await this.repository.All<Publisher>()
                .AnyAsync(p => p.CompanyName == company);

            return result;
        }

        public async Task<bool> PublisherExistsByUserId(string userId)
        {
            bool result = await this.repository.All<Publisher>()
                 .AnyAsync(p => p.UserId.ToString() == userId);

            return result;
        }
        public async Task Create(string userId, BecomePublisherFormModel model)
        {
            Publisher publisher = new Publisher()
            {
                BusinessEmail = model.BusinessEmail,
                CompanyName = model.CompanyName,
                WebsiteURL = model.WebsiteURL,
                UserId = Guid.Parse(userId)
            };

           await this.repository.AddAsync(publisher);
           await this.repository.SaveChangesAsync();
        }

        public async Task<string> PublisherIdByUserIdAsync(string userId)
        {
           Publisher? publisher = await this.repository.AllReadonly<Publisher>()
                .FirstOrDefaultAsync(p=>p.UserId.ToString()==userId);

            if (publisher == null)
            {
                return null;
            }

            return publisher.Id.ToString();

        }
    }
}
