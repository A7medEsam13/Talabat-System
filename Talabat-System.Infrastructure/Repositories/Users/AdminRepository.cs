using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Users;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Users;

namespace Talabat_System.Infrastructure.Repositories.Users
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
