using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamesNexus.Common.EntityValidationConstants.Discussion;

namespace GamesNexus.Data.Models
{
    public class Discussion
    {
        public Discussion()
        {
            this.Comments = new HashSet<Comment>();
            this.CreatedOn = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DiscussionTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DiscussionContentMaxLength)]
        public string Content { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get;  set; }


        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;


        public ICollection<Comment> Comments { get; set; } = null!;
    }
}
