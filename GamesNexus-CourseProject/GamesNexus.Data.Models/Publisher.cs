using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamesNexus.Common.EntityValidationConstants.Publisher;

namespace GamesNexus.Data.Models
{
    public class Publisher
    {
        public Publisher()
        {
            this.Id = Guid.NewGuid();
            this.PublishedGames = new HashSet<Game>();
            this.News = new HashSet<News>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(PublisherCompanyNameMaxLength)]
        public string CompanyName { get; set; } = null!;

        [Required]
        [MaxLength(PublisherEmailMaxLength)]
        public string BusinessEmail { get; set; } = null!;


        [MaxLength(PublisherURLMaxLength)]
        public string? WebsiteURL { get; set; }


        [ForeignKey(nameof(ApplicationUser))]
        public Guid UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;


        public ICollection<Game> PublishedGames { get; set; }
        public ICollection<News> News { get; set; }
    }
}
