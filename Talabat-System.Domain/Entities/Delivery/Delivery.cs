using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Talabat_System.Domain.Entities.Orders;

namespace Talabat_System.Domain.Entities.Delivery
{
    public class Delivery
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int DriverId { get; set; }
        public DateTime AssignedAt { get; set; }
        public DateTime PickedUpAt { get; set; }
        public DateTime DeliveredAt { get; set; }

        // Navigation properties
        [ForeignKey("OrderId")]
        public Order Order { get; set; } = new();
        [ForeignKey("DriverId")]
        public Driver Driver { get; set; } = new();
    }
}
