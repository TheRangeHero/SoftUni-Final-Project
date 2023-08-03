
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
            this.CreatedOn = DateTime.UtcNow;
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
        public DateTime CreatedOn { get;  set; }


        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;


        public ICollection<OrderDetail> OrderDetail { get; set; } = null!;
    }
}
