using GamesNexus.Data.Migrations;
using GamesNexus.Web.ViewModels.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Services.Data.Interfaces
{
    public interface IPublisherService
    {
        Task<bool> PublisherExistsByUserId(string userId);
        Task<bool> PublisherExistsByBusinessEmailAsync(string email);
        Task<bool> PublisherExistsByCompanyNameAsync(string company);
        Task Create(string userId, BecomePublisherFormModel model);
        Task<string?> GetPublisherIdByUserIdAsync(string userId);
        Task<bool> HasGameWithIdAsync (string? userId, long gameId);
        Task<bool> HasNewsWithIdAsync(string? userId, int id);

    }
}
