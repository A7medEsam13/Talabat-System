using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Talabat_System.Domain.Entities.Users;
using Talabat_System.Domain.Enums;

namespace Talabat_System.Domain.Entities.Notifications
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public NotificationType Type { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }


        // navigation.
        [ForeignKey("UserId")]
        public AppUser User { get; set; } = new();
    }
}
