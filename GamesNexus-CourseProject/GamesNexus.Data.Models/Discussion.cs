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
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DiscussionTitleMaxLenght)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DiscussionContentMaxLenght)]
        public string Content { get; set; } = null!;

        [Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;


        public ICollection<Comment> Comments { get; set; } = null!;
    }
}
