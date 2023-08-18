

using GamesNexus.Web.ViewModels.User;

namespace GamesNexus.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<string> GetUsernameByEmailAsync(string username);
        Task<bool> ExistsById(string userId);
        Task<IEnumerable<UserViewModel>> AllAsync();
        Task<bool> HasDiscussionsWithIdAsync(string? userId, int id);


    }
}
