using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Reviews;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Reviews;

namespace Talabat_System.Infrastructure.Repositories.Reviews
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
