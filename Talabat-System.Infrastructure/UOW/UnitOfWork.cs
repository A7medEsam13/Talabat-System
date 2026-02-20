using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Delivery;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Notifications;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Orders;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Payments;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Restaurents;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Reviews;
using Talabat_System.Infrastructure.RepositoriesInterfaces.Users;

namespace Talabat_System.Infrastructure.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context,
            IDeliveryRepository deliveries,
            INotificationRepository notifications,
            IItemRepository items,
            IOrderItemsRepository orderItems,
            IOrderRepository orders,
            IPaymentRepository payments,
            ICategoryRepository categories,
            IMenuItemRepository menuItems,
            IRestaurantRepository restaurants,
            IReviewRepository reviews,
            IAdminRepository admins,
            ICustomerRepository customers,
            IDriverRepository drivers)
        {
            _context = context;
            Deliveries = deliveries;
            Notifications = notifications;
            Items = items;
            OrderItems = orderItems;
            Orders = orders;
            Payments = payments;
            Categories = categories;
            MenuItems = menuItems;
            Restaurants = restaurants;
            Reviews = reviews;
            Admins = admins;
            Customers = customers;
            Drivers = drivers;
        }

        public IDeliveryRepository Deliveries { get; }

        public IDriverRepository Drivers { get; }

        public INotificationRepository Notifications { get; }

        public IItemRepository Items { get; }

        public IOrderItemsRepository OrderItems { get; }
        public IOrderRepository Orders { get; }

        public IPaymentRepository Payments { get; } 

        public ICategoryRepository Categories { get; }

        public IMenuItemRepository MenuItems { get; }

        public IRestaurantRepository Restaurants { get; }
        public IReviewRepository Reviews { get; }

        public IAdminRepository Admins { get; }

        public ICustomerRepository Customers { get; }   

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
