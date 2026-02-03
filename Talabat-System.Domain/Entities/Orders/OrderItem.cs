using System.ComponentModel.DataAnnotations.Schema;
using Talabat_System.Domain.Entities.Restaurants;

namespace Talabat_System.Domain.Entities.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }


        // Navigation Properties
        [ForeignKey("ProductId")]
        public MenuItem MenuItem { get; set; } = new();
        [ForeignKey("OrderId")]
        public Order Order { get; set; } = new();
    }
}