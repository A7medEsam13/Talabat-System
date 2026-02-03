using System;
using System.Collections.Generic;
using System.Text;

namespace Talabat_System.Domain.Entities.Users
{
    public class AppUser
    {
        public AppUser()
        {
            Addresses = new HashSet<Address>();
        }




        // navigation properties.
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
