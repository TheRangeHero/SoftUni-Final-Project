using GamesNexus.Web.ViewModels.Category;
using GamesNexus.Web.ViewModels.Genre;
using System.ComponentModel.DataAnnotations;

using static GamesNexus.Common.EntityValidationConstants.Game;

namespace GamesNexus.Web.ViewModels.Game
{


    public class GameAddFromModel
    {
        public GameAddFromModel()
        {
            this.Genres = new HashSet<GameSelectGenreFormModel>();
            this.Categories = new HashSet<GameSelectCategoryFormModel>();
        }

        public long Id { get; set; }    

        [Required]
        [StringLength(GameTitleMaxLength, MinimumLength = GameTitleMinLength)]
        public string Title { get; set; } = null!;


        [Required]
        [StringLength(GameDescriptionMaxLength)]
        [Display(Name = "Description of the game")]
        public string Description { get; set; } = null!;


        [Required]
        [Range(typeof(decimal), GamePriceMinValue, GamePriceMaxValue)]
        public decimal Price { get; set; }


        [Required]
        [StringLength(GameDeveloperMaxLength, MinimumLength = GameDeveloperMinLength)]
        public string Developer { get; set; } = null!;


        [Required]
        [StringLength(GPUMaxLength, MinimumLength = GPUMinLength)]
        [Display(Name = "Graphics card")]
        public string GPU { set; get; } = null!;


        [Required]
        [StringLength(CPUMaxLength, MinimumLength = CPUMinLength)]
        [Display(Name = "Processor")]
        public string CPU { set; get; } = null!;


        [Required]
        [StringLength(OSMaxLength, MinimumLength = OSMinLength)]
        [Display(Name = "Operating system")]
        public string OS { set; get; } = null!;


        [Required]
        [StringLength(StorageMaxLength, MinimumLength = StorageMinLength)]        
        public string Storage { set; get; } = null!;


        [Required]
        [StringLength(RAMMaxLength, MinimumLength = RAMMinLength)]
        [Display(Name = "Memory")]
        public string RAM { set; get; } = null!;


        [MaxLength(AdditionalNotesMaxLength)]
        [Display(Name = "Memory")]
        public string? AdditionalNotes { set; get; }


        public List<string> ImageUrls { get; set; } = new List<string>();
        public List<string> VideoUrls { get; set; } = new List<string>();

        [Display(Name = "Categories")]
        public int GenreId { get; set; }
        public IEnumerable<GameSelectGenreFormModel> Genres { get; set; }

        [Display(Name = "Genres")]
        public int CategoryId { get; set; }
        public IEnumerable<GameSelectCategoryFormModel> Categories { get; set; }
    }

}
