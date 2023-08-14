
using System.ComponentModel.DataAnnotations;

using static GamesNexus.Common.EntityValidationConstants.News;

namespace GamesNexus.Web.ViewModels.News
{
    public class NewsAddFormModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(NewsTitleMaxLength, MinimumLength = NewsTitleMinLength)]
        public string Title { get; set; } = null!;
        [Required]
        [StringLength(NewsContentMaxLength, MinimumLength = NewsContentMinLength)]
        public string Content { get; set; } = null!;
    }
}
