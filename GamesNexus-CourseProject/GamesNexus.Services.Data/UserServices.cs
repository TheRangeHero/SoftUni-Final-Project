using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.User;
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

        public async Task<IEnumerable<UserViewModel>> AllAsync()
        {
            List<UserViewModel> allUsers =  await repository.AllReadonly<ApplicationUser>()
                .Select(p => new UserViewModel
                {
                    Id = p.Id.ToString(),
                    Username = p.UserName,
                    FullName = p.FirstName + " " + p.LastName,
                }).ToListAsync();
            foreach(var user in allUsers)
            {
                Publisher? publisher = this.repository.AllReadonly<Publisher>()
                    .FirstOrDefault(p=>p.UserId.ToString() == user.Id);

                if(publisher != null)
                {
                    user.BusinessEmail = publisher.BusinessEmail;
                }
            }

            return allUsers;

        }

        public async Task<bool> ExistsById(string userId)
        {
            return await repository.All<ApplicationUser>()
                .AnyAsync(a => a.Id.ToString() == userId);
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
