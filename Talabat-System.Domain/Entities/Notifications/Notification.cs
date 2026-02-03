using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Enums;

namespace Talabat_System.Domain.Entities.Notifications
{
    public class Notification
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public NotificationType Type { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
