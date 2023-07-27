using System.ComponentModel.DataAnnotations.Schema;

namespace GamesNexus.Data.Models
{
    public class GameCategory
    {
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public Game Game { get; set; } = null!;


        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
