using System;
using System.Collections.Generic;
using System.Text;

namespace Talabat_System.Domain.Entities.Restaurants
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public bool IsOpen { get; set; }
        public string Rating { get; set; }
        public DateOnly CreatedAt { get; set; }
    }
}
