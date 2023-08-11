using GamesNexus.Web.ViewModels.Review;
using GamesNexus.Web.ViewModels.SystemRequirement;

namespace GamesNexus.Web.ViewModels.Game
{
    public class GameDetailViewModel
    {

        public GameDetailViewModel()
        {
            this.Genres = new HashSet<string>();
            this.Categories = new HashSet<string>();
            this.Images = new HashSet<string>();
            this.Videos = new HashSet<string?>();
            this.Reviews = new HashSet<ReviewAllViewModel>();

        }

        public long Id { get; set; }

        public string Title { get; set; } = null!;

        public string Image { get; set; } = null!;

        public decimal Price { get; set; }

        public string Description { get; set; } = null!;

        public string ReleaseDate { get; set; } = null!;

        public string Developer { get; set; } = null!;

        public string Publisher { get; set; } = null!;

        public SystemRequirementAllViewModel SystemRequirements { get; set; } = null!;

        public ICollection<string> Genres { get; set; } 
        public ICollection<string> Categories { get; set; } 
        public ICollection<string> Images { get; set; } 
        public ICollection<string?> Videos { get; set; }
        public ICollection<ReviewAllViewModel> Reviews { get; set; }
    }
}
