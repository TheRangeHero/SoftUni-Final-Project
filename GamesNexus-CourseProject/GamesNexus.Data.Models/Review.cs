using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using static GamesNexus.Common.EntityValidationConstants.Review;
using GamesNexus.Data.Models.Enums;

namespace GamesNexus.Data.Models
{
    public class Review
    {
        public Review()
        {
            CreatedAt = DateTime.UtcNow;
            Rating = RatingOption.None;
        }


        [Key]
        public int Id { get; set; }

        public RatingOption Rating { get; set; }

        [MaxLength(ReviewCommentMaxLength)]
        public string? Comment { get; set; }

        [Required]
        public DateTime CreatedAt { get; private set; }


        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;


        [ForeignKey(nameof(Game))]
        public long GameId { get; set; }
        public virtual Game Game { get; set; } = null!;

    }
}
