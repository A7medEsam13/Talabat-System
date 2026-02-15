using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Restaurants;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Restaurents;

namespace Talabat_System.Infrastructure.Repositories.Restaurants
{
    public class MenuItemRepository : GenericRepository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
