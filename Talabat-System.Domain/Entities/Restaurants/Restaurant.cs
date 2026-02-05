using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Talabat_System.Domain.Entities.Orders;
using Talabat_System.Domain.Entities.Reviews;

namespace Talabat_System.Domain.Entities.Restaurants
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public bool IsOpen { get; set; }
        public decimal Rating { get; set; }
        public DateOnly CreatedAt { get; set; }
        public int CategoryId { get; set; }


        // Navigation Properties
        [ForeignKey("CategoryId")]
        public Category Category { get; set; } = new();
        public ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
