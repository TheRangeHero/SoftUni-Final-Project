﻿using System;
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
    {        public News()
        {
            this.PublishedAt = DateTime.UtcNow;
        }


        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NewsTitleMaxLegth)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(NewsContentMaxLength)]
        public string Content { get; set; } = null!;

        public DateTime PublishedAt { get; set; }


        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
