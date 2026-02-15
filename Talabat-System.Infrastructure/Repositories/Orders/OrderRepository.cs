using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Orders;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Orders;

namespace Talabat_System.Infrastructure.Repositories.Orders
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
