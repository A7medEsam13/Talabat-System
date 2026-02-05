using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using Talabat_System.Domain.Entities.Delivery;

namespace Talabat_System.Domain.Entities.Users
{
    public class AppUser : IdentityUser
    {
        public virtual Admin? AdminProfile { get; set; }
        public virtual Customer? CustomerProfile { get; set; }
        public virtual Driver? DriverProfile { get; set; }
    }
}
