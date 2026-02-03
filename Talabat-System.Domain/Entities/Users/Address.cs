using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Talabat_System.Domain.Entities.Users
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Street { get; set; }
        public bool IsDefault { get; set; }



        // Navigation propertiies.

        [InverseProperty("Address")]
        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
    }
}
