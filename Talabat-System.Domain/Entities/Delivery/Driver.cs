using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Talabat_System.Domain.Entities.Users;

namespace Talabat_System.Domain.Entities.Delivery
{
    public class Driver
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsAvailable { get; set; }
        public decimal CurrentLatitude { get; set; }
        public decimal CurrentLongitude { get; set; }

        // Navigation properties
        [ForeignKey("UserId")]
        public AppUser User { get; set; } = new();
    }
}
