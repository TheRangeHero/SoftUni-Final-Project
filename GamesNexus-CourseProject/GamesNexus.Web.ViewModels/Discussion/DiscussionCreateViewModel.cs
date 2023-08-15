using System.ComponentModel.DataAnnotations;
using static GamesNexus.Common.EntityValidationConstants.Discussion;

namespace GamesNexus.Web.ViewModels.Discussion
{
    public class DiscussionCreateViewModel
    {
        [Required]
        [StringLength(DiscussionTitleMaxLength, MinimumLength = DiscussionTitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DiscussionContentMaxLength, MinimumLength = DiscussionContentMinLength)]
        public string Content { get; set; } = null!;
    }
}
