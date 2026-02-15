using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Delivery;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Delivery;

namespace Talabat_System.Infrastructure.Repositories.Delivery
{
    public class DriverRepository : GenericRepository<Driver>, IDriverRepository
    {
        public DriverRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
