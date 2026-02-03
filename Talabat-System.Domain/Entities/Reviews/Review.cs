using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Talabat_System.Domain.Entities.Orders;
using Talabat_System.Domain.Entities.Restaurants;
using Talabat_System.Domain.Entities.Users;

namespace Talabat_System.Domain.Entities.Reviews
{
    public class Review
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int RestaurentId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }


        // Navigation Properties
        [ForeignKey("OrderId")]
        public Order Order { get; set; } = new();
        [ForeignKey("UserId")]
        public AppUser User { get; set; } = new();
        [ForeignKey("RestaurentId")]
        public Restaurant Restaurent { get; set; } = new();
    }
}
