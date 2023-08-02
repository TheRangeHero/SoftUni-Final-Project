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
            this.GamesGenres = new HashSet<GameGenre>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GenreNameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<GameGenre> GamesGenres { get; set; } = null!;
    }
}
