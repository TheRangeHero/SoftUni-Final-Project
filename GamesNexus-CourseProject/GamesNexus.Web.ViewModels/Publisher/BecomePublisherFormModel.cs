using System.ComponentModel.DataAnnotations;

using static GamesNexus.Common.EntityValidationConstants.Publisher;

namespace GamesNexus.Web.ViewModels.Publisher
{
    public class BecomePublisherFormModel
    {
        [Required]
        [StringLength(PublisherCompanyNameMaxLength, MinimumLength =PublisherCompanyNameMinLength)]
        [Display(Name = "Your Company Name")]
        public string CompanyName { get; set; } = null!;

        [Required]
        [StringLength(PublisherEmailMaxLength, MinimumLength = PublisherEmailMinLength)]
        [Display(Name = "Your Business Email")]
        public string BusinessEmail { get; set; } = null!;

        [StringLength(PublisherURLMaxLength)]
        [Display(Name = "Business Website direct link")]
        public string? WebsiteURL { get; set; }
    }
}
