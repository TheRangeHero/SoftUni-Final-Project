using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static GamesNexus.Common.EntityValidationConstants.ApplicationUser;

namespace GamesNexus.Data.Models
{
    public class ApplicationUser:IdentityUser<Guid>
    {        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
            this.Discussions = new HashSet<Discussion>();
            this.Comments = new HashSet<Comment>();
            this.Orders = new HashSet<Order>();
            this.Reviews = new HashSet<Review>();
            this.News = new HashSet<News>();
        }


        [MaxLength(ApplicationUserFirstNameMaxLength)]
        public string? FirstName { get; set; }

        [MaxLength(ApplicationUserLastNameMaxLength)]
        public string? LastName { get; set; }

        [MaxLength(ApplicationUserAvatarURLMaxLenght)]
        public string? AvatarImage { get; set; }

        [MaxLength(ApplicationUserCountryMaxLenght)]
        public string? Country { get; set; }

        [MaxLength(ApplicationUserStateCityMaxLenght)]
        public string? StateCity { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [ForeignKey(nameof(Wishlist))]
        public int WishlistId { get; set; }
        public Wishlist? Wishlist { get; set; }

        public ICollection<Discussion>? Discussions { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<News>? News { get; set; }
    }
}
