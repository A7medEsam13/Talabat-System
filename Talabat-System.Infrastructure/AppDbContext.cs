using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Talabat_System.Domain.Entities.Delivery;
using Talabat_System.Domain.Entities.Notifications;
using Talabat_System.Domain.Entities.Orders;
using Talabat_System.Domain.Entities.Payments;
using Talabat_System.Domain.Entities.Restaurants;
using Talabat_System.Domain.Entities.Reviews;
using Talabat_System.Domain.Entities.Users;

namespace Talabat_System.Infrastructure
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Model configurations go here

            modelBuilder.Entity<OrderItems>()
                .HasKey(e => new { e.OrderId, e.ItemId });

            modelBuilder.Entity<Item>()
                .HasOne(i => i.MenuItem)
                .WithOne(mi => mi.Item)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<OrderItems>()
                .HasOne(oi => oi.Order)
                .WithMany(oi => oi.Items)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderItems>()
                .HasOne(oi => oi.Item)
                .WithMany(oi => oi.OrderItems)
                .HasForeignKey(oi => oi.ItemId)
                .OnDelete(DeleteBehavior.Restrict);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
    }
}