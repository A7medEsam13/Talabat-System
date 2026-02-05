using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Talabat_System.Domain.Entities.Orders;
using Talabat_System.Domain.Enums;

namespace Talabat_System.Domain.Entities.Payments
{
    public class Payment
    {
        public Payment()
        {
            Order = new();
        }
        [Key]
        public Guid Id { get; set; }
        public int OrderId { get; set; }
        public PaymentMethod Method{ get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }

        // navigations
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
