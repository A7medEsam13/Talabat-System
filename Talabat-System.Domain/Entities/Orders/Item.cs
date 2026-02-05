using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Talabat_System.Domain.Entities.Restaurants;

namespace Talabat_System.Domain.Entities.Orders
{
    public class Item
    {
        public Item()
        {
            MenuItem = new();
            OrderItems = new List<OrderItems>();
        }
        [Key]
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        public decimal UnitPrice { get; set; }


        // Navigation Properties
        [ForeignKey("MenuItemId")]        
        public MenuItem MenuItem { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}