using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Talabat_System.Domain.Entities.Users
{
    public class Admin
    {
        public Admin()
        {
            User = new();
        }
        [Key]
        public string UserId { get; set; }
        public string Name { get; set; }

        [ForeignKey("UserId")]
        public AppUser User { get; set; } 
    }
}
