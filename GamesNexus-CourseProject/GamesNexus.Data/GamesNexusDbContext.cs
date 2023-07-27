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

        //TO DO Add DB sets
        //TO DO Configure OnModelCreating
        //TO DO Configure data types for all sets

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}