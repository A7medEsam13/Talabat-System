using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Payments;

namespace Talabat_System.Infrastructure.RepositoriesInterfaces.Payments
{
    public interface IPaymentRepository : IGenericRepository<Payment>
    {
    }
}
