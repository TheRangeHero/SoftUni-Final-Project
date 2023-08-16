using System.ComponentModel.DataAnnotations;

using static GamesNexus.Common.EntityValidationConstants.Review;

namespace GamesNexus.Web.ViewModels.Review
{
    public class ReviewPostViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(ReviewCommentMaxLength, MinimumLength =ReviewCommentMinLength)]
        public string Review { get; set; } = null!;

        public int Rating { get; set; }

        public long GameId { get; set; }
        public Guid UserId { get; set; }

        public Dictionary<int, string> RatingOptions { get; set; } = new Dictionary<int, string>();

    }
}
