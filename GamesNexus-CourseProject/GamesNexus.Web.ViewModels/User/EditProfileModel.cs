using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static GamesNexus.Common.EntityValidationConstants.ApplicationUser;

namespace GamesNexus.Web.ViewModels.User
{
    public class EditProfileModel
    {
        [StringLength(UsernameMaxLength, MinimumLength = UsernameMinLength, ErrorMessage = "The username must be between {2} and {1} symbols.")]
        [RegularExpression(UsernameRegexPattern, ErrorMessage = "The username must contain only letters, digits and underscores.")]
        [Display(Name = "Username")]
        public string Username { get; set; } = null!;

        [RegularExpression(ApplicationUserFirstNameRegexPattern, ErrorMessage = "The first name must contain only letters.")]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [RegularExpression(ApplicationUserLastNameRegexPattern, ErrorMessage = "The last name must contain only letters.")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [RegularExpression(ApplicationUserCountryRegexPattern, ErrorMessage = "The country must contain only letters.")]
        public string? Country { get; set; }

        [RegularExpression(ApplicationUserCityRegexPattern, ErrorMessage = "The city must contain only letters.")]
        public string? City { get; set; }
    }
}
