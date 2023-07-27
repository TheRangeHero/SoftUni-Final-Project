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
            this.Categories = new HashSet<Category>();
            this.Genres = new HashSet<Genre>();
            this.Images = new HashSet<GameImage>();
            this.Videos = new HashSet<GameVideo>();
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
        public DateTime ReleaseDate { get; set; }

        [Required]
        [MaxLength(GameDeveloperMaxLenght)]
        public string Developer { get; set; } = null!;

        [ForeignKey(nameof(Publisher))]
        public Guid PublisherId { get; set; }
        public Publisher Publisher { get; set; } = null!;

        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public ICollection<Genre> Genres { get; set; } = null!;
        public ICollection<Category> Categories { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
        public ICollection<GameImage> Images { get; set; } = null!;
        public ICollection<GameVideo> Videos { get; set; } = null!;
    }
}
