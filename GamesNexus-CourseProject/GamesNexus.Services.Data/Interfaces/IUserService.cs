

namespace GamesNexus.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<string> GetUsernameByEmailAsync(string username);
        Task<bool> ExistsById(string userId);
        
    }
}
