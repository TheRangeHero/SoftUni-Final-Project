using GamesNexus.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GamesNexus.Data
{
    public class GamesNexusDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public GamesNexusDbContext(DbContextOptions<GamesNexusDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        public DbSet<Discussion> Discussions { get; set; } = null!;
        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<GameCategory> GamesCategories { get; set; } = null!;
        public DbSet<GameGenre> GamesGenres { get; set; } = null!;
        public DbSet<GameImage> GamesImages { get; set; } = null!;
        public DbSet<GameVideo> GamesVideos { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<News> News { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Publisher> Publishers { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<SystemRequirement> SystemRequirements { get; set; } = null!;

        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(GamesNexusDbContext)) ?? Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);
        }
    }
}