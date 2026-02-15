using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Orders;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Orders;

namespace Talabat_System.Infrastructure.Repositories.Orders
{
    public class OrderItemsRepository : GenericRepository<OrderItems>, IOrderItemsRepository
    {
        public OrderItemsRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
