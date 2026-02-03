using System;
using System.Collections.Generic;
using System.Text;

namespace Talabat_System.Domain.Entities.Enums
{
    public enum OrderStatus
    {
        Created,
        Paid,
        Accepted,
        Preparing,
        PickedUp,
        Delivered,
        Canceled
    }
}
