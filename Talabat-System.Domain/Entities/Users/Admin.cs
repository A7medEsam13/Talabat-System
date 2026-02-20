using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Talabat_System.Domain.Entities.Restaurants;

namespace Talabat_System.Domain.Entities.Users
{
    public class Admin
    {
        public Admin()
        {
            User = new();
            Restaurant = new();
        }
        [Key]
        public string UserId { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; }

        [ForeignKey("UserId")]
        public AppUser User { get; set; }
        [ForeignKey("RestaurantId")]
        public Restaurant Restaurant { get; set; }
    }
}
