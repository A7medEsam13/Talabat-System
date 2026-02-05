using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Talabat_System.Domain.Entities.Orders;

namespace Talabat_System.Domain.Entities.Restaurants
{
    public class MenuItem
    {
        public MenuItem()
        {
            Restaurant = new();
            Item = new();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public int RestaurantId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public bool IsAvailabel { get; set; }


        // navigation props.

        [ForeignKey("ReastaurantId")]
        public Restaurant Restaurant { get; set; } 
        public Item Item { get; set; }
    }
}
