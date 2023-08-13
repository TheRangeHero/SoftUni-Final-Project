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
            this.OrderDetail = new HashSet<OrderDetail>();
            this.ReleaseDate = DateTime.UtcNow;
        }

        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(GameTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(GameDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

       
        public DateTime ReleaseDate { get;  set; }


        [Required]
        [MaxLength(GameDeveloperMaxLength)]
        public string Developer { get; set; } = null!;


        [Required]
        [MaxLength(GPUMaxLength)]
        public string GPU { set; get; } = null!;


        [Required]
        [MaxLength(CPUMaxLength)]
        public string CPU { set; get; } = null!;


        [Required]
        [MaxLength(OSMaxLength)]
        public string OS { set; get; } = null!;


        [Required]
        [MaxLength(StorageMaxLength)]
        public string Storage { set; get; } = null!;


        [Required]
        [MaxLength(RAMMaxLength)]
        public string RAM { set; get; } = null!;


        [MaxLength(AdditionalNotesMaxLength)]
        public string? AdditionalNotes { set; get; }


        [Required]
        [MaxLength(GameImageURLMaxLength)]
        public string Image1URL { get; set; } = null!;


        [MaxLength(GameImageURLMaxLength)]
        public string? Image2URL { get; set; }


        [MaxLength(GameImageURLMaxLength)]
        public string? Image3URL { get; set; }

        [Required]
        [MaxLength(GameVideoURLMaxLength)]
        public string VideoURL { get; set; } = null!;


        [ForeignKey(nameof(Publisher))]
        public Guid PublisherId { get; set; }
        public Publisher Publisher { get; set; } = null!;


        [ForeignKey(nameof(ApplicationUser))]
        public Guid? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public ICollection<GameGenre> GamesGenres { get; set; } 
        public ICollection<GameCategory> GamesCategories { get; set; } 
        public ICollection<Review> Reviews { get; set; } 
        public ICollection<OrderDetail> OrderDetail { get; set; } 
    }
}
