using System;
using System.Collections.Generic;
using System.Text;

namespace Talabat_System.Domain.Entities.Restaurants
{
    public class MenuItem
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailabel { get; set; }
    }
}
