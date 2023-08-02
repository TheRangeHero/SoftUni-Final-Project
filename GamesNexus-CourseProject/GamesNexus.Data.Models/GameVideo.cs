using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using static GamesNexus.Common.EntityValidationConstants.GameVideo;

namespace GamesNexus.Data.Models
{
    public class GameVideo
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(GameVideoURLMaxLenght)]
        public string? VideoUrl { get; set; }


        [ForeignKey(nameof(Game))]
        public long GameId { get; set; }
        public Game Game { get; set; } = null!;
    }
}
