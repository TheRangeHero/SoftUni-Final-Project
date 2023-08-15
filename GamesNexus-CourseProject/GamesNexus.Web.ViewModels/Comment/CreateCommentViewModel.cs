using System.ComponentModel.DataAnnotations;
using static GamesNexus.Common.EntityValidationConstants.Comment;

namespace GamesNexus.Web.ViewModels.Comment
{
    public class CreateCommentViewModel
    {
        public int Id { get; set; }

        public int DiscussionId { get; set; }

        [Required]
        [StringLength(CommentContentMaxLength,MinimumLength =CommentContentMinLength)]
        public string Content { get; set; } = null!;
    }
}
