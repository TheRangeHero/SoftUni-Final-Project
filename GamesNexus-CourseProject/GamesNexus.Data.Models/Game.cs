using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamesNexus.Common.EntityValidationConstants.Game;

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
            this.ReleaseDate = DateTime.Now.Date;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GameTitleMaxLenght)]
        public string Title { get; set; } = null!;

        [MaxLength(GameDescriptionMaxLenght)]
        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime ReleaseDate { get; private set; }


        [Required]
        [MaxLength(GameDeveloperMaxLenght)]
        public string Developer { get; set; } = null!;


        [ForeignKey(nameof(Publisher))]
        public Guid PublisherId { get; set; }
        public Publisher Publisher { get; set; } = null!;


        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }
        public Order Order { get; set; } = null!;

        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;


        public ICollection<GameGenre> GamesGenres { get; set; } = null!;
        public ICollection<GameCategory> GamesCategories { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
        public ICollection<GameImage> Images { get; set; } = null!;
        public ICollection<GameVideo> Videos { get; set; } = null!;
    }
}
