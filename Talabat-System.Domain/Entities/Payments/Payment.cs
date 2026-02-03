using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Enums;

namespace Talabat_System.Domain.Entities.Payments
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public PaymentMethod Method{ get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
