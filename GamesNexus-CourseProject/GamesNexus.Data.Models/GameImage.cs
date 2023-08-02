using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using static GamesNexus.Common.EntityValidationConstants.GameImage;

namespace GamesNexus.Data.Models
{
    public class GameImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GameImageURLMaxLength)]
        public string ImageUrl { get; set; } = null!;


        [ForeignKey(nameof(Game))]
        public long GameId { get; set; }
        public Game Game { get; set; } = null!;
    }
}
