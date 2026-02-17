using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Delivery;

namespace Talabat_System.Infrastructure.Repositories.Delivery
{
    public class DeliveryRepository : GenericRepository<Domain.Entities.Delivery.Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
