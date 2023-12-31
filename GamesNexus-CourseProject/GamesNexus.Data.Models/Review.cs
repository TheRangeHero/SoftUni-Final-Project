﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using static GamesNexus.Common.EntityValidationConstants.Review;
using GamesNexus.Data.Models.Enums;

namespace GamesNexus.Data.Models
{
    public class Review
    {
        public Review()
        {
            this.PostedOn = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        public RatingOption Rating { get; set; }

        [Required]
        [MaxLength(ReviewCommentMaxLength)]
        public string Comment { get; set; } = null!;

        [Required]
        public DateTime PostedOn { get;  set; }

        public bool IsActive { get; set; } = true;


        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;


        [ForeignKey(nameof(Game))]
        public long GameId { get; set; }
        public virtual Game Game { get; set; } = null!;

    }
}
