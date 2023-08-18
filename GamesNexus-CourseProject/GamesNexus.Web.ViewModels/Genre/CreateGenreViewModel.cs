using System.ComponentModel.DataAnnotations;

using static GamesNexus.Common.EntityValidationConstants.Genre;

namespace GamesNexus.Web.ViewModels.Genre
{
    public class CreateGenreViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(GenreNameMaxLength, MinimumLength = GenreNameMinLength)]
        public string Name { get; set; } = null!;
    }
}
