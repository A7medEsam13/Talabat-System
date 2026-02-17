using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using Talabat_System.Infrastructure;
using Talabat_System.Infrastructure.Repositories.Delivery;
using Talabat_System.Infrastructure.Repositories.Notification;
using Talabat_System.Infrastructure.Repositories.Orders;
using Talabat_System.Infrastructure.Repositories.Payments;
using Talabat_System.Infrastructure.Repositories.Restaurants;
using Talabat_System.Infrastructure.Repositories.Reviews;
using Talabat_System.Infrastructure.Repositories.Users;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Delivery;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Notifications;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Orders;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Payments;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Restaurents;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Reviews;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Users;

namespace Talabat_System.Extensions
{
    public static class ServicesExtensions
    {
        extension(IServiceCollection services)
        {
            public void ConnectDatabase(ConfigurationManager configuration)
            {
                services.AddDbContext<AppDbContext>(options =>
                    options
                    .UseSqlServer(configuration.GetConnectionString("Default"))
                );
            }

            public void RegisterServices()
            {
                services.AddScoped<IDeliveryRepository, DeliveryRepository>();
                services.AddScoped<IDriverRepository, DriverRepository>();
                services.AddScoped<INotificationRepository, NotificationRepository>();
                services.AddScoped<IItemRepository, ItemRepository>();
                services.AddScoped<IOrderItemsRepository, OrderItemsRepository>();
                services.AddScoped<IOrderRepository, OrderRepository>();
                services.AddScoped<IPaymentRepository, PaymentRepository>();
                services.AddScoped<ICategoryRepository, CategoryRepository>();
                services.AddScoped<IMenuItemRepository, MenuItemRepository>();
                services.AddScoped<IRestaurantRepository, RestaurantRepository>();
                services.AddScoped<IReviewRepository, ReviewRepository>();
                services.AddScoped<IAdminRepository, AdminRepository>();
                services.AddScoped<ICustomerRepository, CustomerRepository>();
            }
        }
    }
}
