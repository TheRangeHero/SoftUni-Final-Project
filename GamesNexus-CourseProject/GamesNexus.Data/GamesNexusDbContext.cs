using GamesNexus.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GamesNexus.Data
{
    public class GamesNexusDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public GamesNexusDbContext(DbContextOptions<GamesNexusDbContext> options)
            : base(options)
        {
        }
    }
}