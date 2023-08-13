using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GamesNexus.Common.EntityValidationConstants.News;

namespace GamesNexus.Data.Models
{
    public class News
    {
        public News()
        {
            this.PublishedOn = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NewsTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(NewsContentMaxLength)]
        public string Content { get; set; } = null!;

        public DateTime PublishedOn { get;  set; }

        public bool IsActive { get; set; } = true;


        [ForeignKey(nameof(Publisher))]
        public Guid PublisherId { get; set; } 
        public Publisher Publisher { get; set; } = null!;
    }
}
