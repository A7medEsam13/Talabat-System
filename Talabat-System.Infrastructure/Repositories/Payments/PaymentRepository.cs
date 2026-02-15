using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Payments;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Payments;

namespace Talabat_System.Infrastructure.Repositories.Payments
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
