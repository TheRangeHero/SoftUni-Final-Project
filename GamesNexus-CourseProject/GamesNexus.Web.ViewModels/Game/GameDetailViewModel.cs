using GamesNexus.Web.ViewModels.SystemRequirement;

namespace GamesNexus.Web.ViewModels.Game
{
    public class GameDetailViewModel
    {

        public long Id { get; set; }

        public string Title { get; set; } = null!;

        public string Image { get; set; } = null!;

        public decimal Price { get; set; }

        public string Description { get; set; } = null!;

        public DateTime ReleaseDate { get; set; }

        public string Developer { get; set; } = null!;

        public string Publisher { get; set; } = null!;

        public SystemRequirementAllViewModel SystemRequirements { get; set; } = null!;

        public ICollection<string> Genres { get; set; } = null!;
        public ICollection<string> Categories { get; set; } = null!;
        public ICollection<string> Images { get; set; } = null!;
        public ICollection<string>? Videos { get; set; }
    }
}
