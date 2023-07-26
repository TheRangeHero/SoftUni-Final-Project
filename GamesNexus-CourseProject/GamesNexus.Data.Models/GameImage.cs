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
        [MaxLength(GameImageURLMaxLenght)]
        public string ImageUrl { get; set; } = null!;


        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public Game Game { get; set; } = null!;
    }
}
