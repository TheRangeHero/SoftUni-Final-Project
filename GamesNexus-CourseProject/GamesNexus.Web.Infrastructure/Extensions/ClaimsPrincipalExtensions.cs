using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using static GamesNexus.Common.GeneralApplicationConstants;

namespace GamesNexus.Web.Infrastructure.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string? GetId(this ClaimsPrincipal user)
        {
            string? id = null;

            if (user != null)
            {
                return user.FindFirstValue(ClaimTypes.NameIdentifier);

            }
            return id;

        }

        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(AdminRoleName);
        }

    }
}
