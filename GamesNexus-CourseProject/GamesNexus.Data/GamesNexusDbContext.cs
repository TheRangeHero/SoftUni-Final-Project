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
        //TO DO Make configuration for every entity

//        Game:
//-- Genre Many-to-Many
//-- Category Many-to-Many
//-- Review One-To-Many
//-- Images One-to-many
//-- Videos One-to-Many

//Publisher:
//-- Game One-to-Many

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}