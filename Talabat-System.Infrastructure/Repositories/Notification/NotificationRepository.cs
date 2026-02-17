using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Notifications;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Notifications;

namespace Talabat_System.Infrastructure.Repositories.Notification
{
    public class NotificationRepository : GenericRepository<Domain.Entities.Notifications.Notification>, INotificationRepository
    {
        public NotificationRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
