﻿
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace GamesNexus.Data.Models
{
    public class Wishlist
    {
        public Wishlist()
        {
            this.WishlistedGames = new HashSet<Game>();
        }


        [Key]
        public int Id { get; set; }


        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public virtual ICollection<Game>? WishlistedGames { get; set; }
    }
}
