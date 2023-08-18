using System.ComponentModel.DataAnnotations;

using static GamesNexus.Common.EntityValidationConstants.Category;

namespace GamesNexus.Web.ViewModels.Category
{
    public class CreateCategoryViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(CategoryMaxLength, MinimumLength = CategoryMinLength)]
        public string Name { get; set; } = null!;
    }
}
