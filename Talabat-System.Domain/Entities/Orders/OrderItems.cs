using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Talabat_System.Domain.Entities.Orders
{
    public class OrderItems
    {
        public OrderItems()
        {
            Order = new();
            Item = new();
        }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }


        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }

    }
}
