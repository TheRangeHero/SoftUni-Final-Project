using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamesNexus.Common.EntityValidationConstants.Game;
using System.Numerics;

namespace GamesNexus.Data.Models
{
    public class Game
    {
        public Game()
        {
            this.Reviews = new HashSet<Review>();
            this.GamesCategories = new HashSet<GameCategory>();
            this.GamesGenres = new HashSet<GameGenre>();
            this.Images = new HashSet<GameImage>();
            this.Videos = new HashSet<GameVideo>();
            this.OrderDetail = new HashSet<OrderDetail>();
            this.ReleaseDate = DateTime.Now.Date;
        }

        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(GameTitleMaxLength)]
        public string Title { get; set; } = null!;

        [MaxLength(GameDescriptionMaxLength)]
        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime ReleaseDate { get; private set; }


        [Required]
        [MaxLength(GameDeveloperMaxLength)]
        public string Developer { get; set; } = null!;


        [ForeignKey(nameof(Publisher))]
        public Guid PublisherId { get; set; }
        public Publisher Publisher { get; set; } = null!;


        [ForeignKey(nameof(ApplicationUser))]
        public Guid? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public long SystemRequirementId { get; set; }
        public SystemRequirement? SystemRequirement { get; set; }


        public ICollection<GameGenre> GamesGenres { get; set; } = null!;
        public ICollection<GameCategory> GamesCategories { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
        public ICollection<GameImage> Images { get; set; } = null!;
        public ICollection<GameVideo> Videos { get; set; } = null!;
        public ICollection<OrderDetail> OrderDetail { get; set; } = null!;
    }
}
