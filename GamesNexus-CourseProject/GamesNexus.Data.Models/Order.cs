
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace GamesNexus.Data.Models
{
    public class Order
    {
        public Order()
        {
            this.Id = Guid.NewGuid();
            this.GamesToBuy = new HashSet<Game>();
            CreatedAt = DateTime.UtcNow;
        }

        [Key]
        public Guid Id { get; set; }


        public decimal TotalPrice
        {
            get
            {
                return GamesToBuy?.Sum(game => game.Price) ?? 0;
            }
        }

        [Required]
        public DateTime CreatedAt { get; set; }


        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;


        public ICollection<Game> GamesToBuy { get; set; } = null!;
    }
}
