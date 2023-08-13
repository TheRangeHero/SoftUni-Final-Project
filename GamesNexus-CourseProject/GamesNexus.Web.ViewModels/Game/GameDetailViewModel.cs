using GamesNexus.Web.ViewModels.Review;
using System.ComponentModel.DataAnnotations;

namespace GamesNexus.Web.ViewModels.Game
{
    public class GameDetailViewModel
    {

        public GameDetailViewModel()
        {
            this.Genres = new HashSet<string>();
            this.Categories = new HashSet<string>();
            this.Reviews = new HashSet<ReviewAllViewModel>();

        }

        public long Id { get; set; }

        public string Title { get; set; } = null!;

        public string Image { get; set; } = null!;

        public decimal Price { get; set; }

        public string Description { get; set; } = null!;

        [Display(Name = "Release date")]
        public string ReleaseDate { get; set; } = null!;

        public string Developer { get; set; } = null!;

        [Display(Name = "Operating system")]
        public string OS { get; set; } = null!;

        [Display (Name = "Processor")]
        public string CPU { get; set; } = null!;

        [Display(Name = "Graphics card")]
        public string GPU { get; set; } = null!;

        public string Storage { get; set; } = null!;

        [Display(Name = "Memory")]
        public string RAM { get; set; } = null!;

        [Display(Name = "Additional Notes")]
        public string AdditionalNotes { get; set; } = null!;

        public string Publisher { get; set; } = null!;
        public string Image1 { get; set; } = null!; 
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string Video { get; set; } = null!;


        public ICollection<string> Genres { get; set; }
        public ICollection<string> Categories { get; set; }
        public ICollection<ReviewAllViewModel> Reviews { get; set; }
    }
}
