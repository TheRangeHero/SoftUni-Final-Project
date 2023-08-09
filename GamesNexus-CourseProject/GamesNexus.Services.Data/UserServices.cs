using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace GamesNexus.Services.Data
{
    public class UserServices : IUserService
    {
        private readonly IRepository repository;

        public UserServices(IRepository _repository)
        {
            this.repository = _repository;
        }

        public async Task<string> GetUsernameByEmailAsync(string username)
        {
            ApplicationUser? user = await this.repository.AllReadonly<ApplicationUser>()
                .FirstOrDefaultAsync(x => x.UserName == username);

            if (user == null)
            {
                return string.Empty;
            }

            return user.UserName;
        }
    }
}
