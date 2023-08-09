using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using static GamesNexus.Common.EntityValidationConstants.ApplicationUser;
namespace GamesNexus.Web.ViewModels.User
{
    public class RegisterFormModel
    {

        [Required]
        [StringLength(UsernameMaxLength, MinimumLength = UsernameMinLength, ErrorMessage = "The username must be between {2} and {1} symbols.")]
        [RegularExpression(UsernameRegexPattern, ErrorMessage = "The username must contain only letters, digits and underscores.")]
        [Display(Name = "Username")]
        public string Username { get; set; } = null!;

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength, ErrorMessage = "The password must be between {2} and {1} symbols.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = null!;


        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
