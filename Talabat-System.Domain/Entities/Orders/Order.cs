using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Talabat_System.Domain.Entities.Enums;
using Talabat_System.Domain.Entities.Restaurants;
using Talabat_System.Domain.Entities.Users;

namespace Talabat_System.Domain.Entities.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RestaurentId { get; set; }
        public int? DriverId { get; set; }
        public OrderStatus Status { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DeliveryFees { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime CreatedAt { get; set; }


        // Navigation Properties
        public ICollection<OrderItem> OrderItems { get; set; }
        [ForeignKey("UserId")]
        public AppUser User { get; set; } = new();
        [ForeignKey("RestaurentId")]
        public Restaurant Restaurant { get; set; } = new();
        [ForeignKey("DriverId")]
        public AppUser? Driver { get; set; }
    }
}
