using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Talabat_System.Domain.Entities.Users
{
    public class Customer
    {
        public Customer()
        {
            User = new();
        }

        [Key]
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }
    }
}
