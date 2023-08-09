using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<string> GetUsernameByEmailAsync(string username);
    }
}
