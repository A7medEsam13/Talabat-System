using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Restaurants;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Restaurents;

namespace Talabat_System.Infrastructure.Repositories.Restaurants
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
