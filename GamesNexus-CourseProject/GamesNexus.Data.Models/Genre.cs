using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamesNexus.Common.EntityValidationConstants.Genre;

namespace GamesNexus.Data.Models
{
    public class Genre
    {        public Genre()
        {
            this.GenreGames = new HashSet<Game>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GenreNameMaxLenght)]
        public string Type { get; set; } = null!;

        public ICollection<Game> GenreGames { get; set; } = null!;
    }
}
