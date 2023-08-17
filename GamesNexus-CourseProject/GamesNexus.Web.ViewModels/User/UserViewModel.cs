using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Web.ViewModels.User
{
    public class UserViewModel
    {
        public string Id { get; set; } = null!;

        public string? BusinessEmail { get; set; }

        public string? FullName { get; set; }

        public string Username { get; set; } = null!;
    }
}
