using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamesNexus.Common.EntityValidationConstants.Comment;

namespace GamesNexus.Data.Models
{
    public class Comment
    {
        public Comment()
        {
            this.CreatedAt = DateTime.Now.Date;
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(CommentContentMaxLength)]
        public string? Content { get; set; }

        public DateTime CreatedAt { get; private set; }


        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;


        [ForeignKey(nameof(Discussion))]
        public int DiscussionId { get; set; }
        public Discussion Discussion { get; set; } = null!;
    }
}
