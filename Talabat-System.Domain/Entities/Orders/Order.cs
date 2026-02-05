using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Talabat_System.Domain.Entities.Delivery;
using Talabat_System.Domain.Entities.Payments;
using Talabat_System.Domain.Entities.Restaurants;
using Talabat_System.Domain.Entities.Users;
using Talabat_System.Domain.Enums;

namespace Talabat_System.Domain.Entities.Orders
{
    public class Order
    {
        public Order()
        {
            Items = new List<OrderItems>();
            User = new();
            Delivery = new();
            Restaurant = new();
            Payment = new();
        }


        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int RestaurentId { get; set; }
        public int? DeliveryId { get; set; }
        public OrderStatus Status { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DeliveryFees { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Destination { get; set; }
        public int PaymentId { get; set; }


        // Navigation Properties
        public ICollection<OrderItems> Items { get; set; }
        [ForeignKey("UserId")]
        public AppUser User { get; set; }
        [ForeignKey("RestaurentId")]
        public Restaurant Restaurant { get; set; } 
        [ForeignKey("DeliveryId")]
        public Delivery.Delivery? Delivery { get; set; } 
        public Payment Payment { get; set; }
    }
}
