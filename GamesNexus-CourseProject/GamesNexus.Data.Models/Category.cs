using System.ComponentModel.DataAnnotations;

using static GamesNexus.Common.EntityValidationConstants.Category;

namespace GamesNexus.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.GamesCategories = new HashSet<GameCategory>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryMaxLenght)]
        public string Name { get; set; } = null!;


        public ICollection<GameCategory> GamesCategories { get; set; } = null!;
    }
}
