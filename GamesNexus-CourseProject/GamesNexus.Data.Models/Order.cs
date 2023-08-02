
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace GamesNexus.Data.Models
{
    public class Order
    {
        public Order()
        {
            this.Id = Guid.NewGuid();
            this.OrderDetail = new HashSet<OrderDetail>();
            CreatedAt = DateTime.UtcNow;
        }

        [Key]
        public Guid Id { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return OrderDetail?.Sum(od => od.Game.Price) ?? 0;
            }
            private set
            {

            }
        }

        [Required]
        public DateTime CreatedAt { get; private set; }


        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;


        public ICollection<OrderDetail> OrderDetail { get; set; } = null!;
    }
}
