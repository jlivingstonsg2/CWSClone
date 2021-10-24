using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebPage8.Models;

namespace WebPage8.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ComputerOrder> ComputerOrders { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ComputerOrder>()
                .HasOne<Computer>(ky => ky.Computer)
                .WithMany(k => k.ComputerOrders)
                .HasForeignKey(ky => ky.ComputerId);

            modelBuilder.Entity<ComputerOrder>()
                .HasOne<Order>(ky => ky.Order)
                .WithMany(y => y.ComputerOrders)
                .HasForeignKey(ky => ky.OrderId);

            modelBuilder.Entity<Review>()
                .HasOne(c => c.Computer)
                .WithMany(r => r.Reviews);

            modelBuilder.Entity<Review>()
                .HasOne(c => c.Customer)
                .WithMany(r => r.Reviews);

            modelBuilder.Entity<Computer>()
                .HasOne(c => c.Category)
                .WithMany(r => r.Computers);

            modelBuilder.Entity<Computer>()
                .HasMany(r => r.Reviews);

            modelBuilder.Entity<Customer>()
                .HasMany(r => r.Reviews);

            modelBuilder.Entity<Computer>().HasData(
                new Computer
                {
                    ComputerId = 1,
                    Name = "A",
                    Price = 4500,
                    Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                    RAM = "32GB",
                    HardDisk = "",
                    SystemType = "64-bit operating system, x64-based processor",
                    PenAndTouch = "No pen and touch input is available for this display",
                    ImageUrl = "",
                    CategoryId = 1
                },
                new Computer
                {
                    ComputerId = 2,
                    Name = "B",
                    Price = 7000,
                    Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                    RAM = "32GB",
                    HardDisk = "",
                    SystemType = "64-bit operating system, x64-based processor",
                    PenAndTouch = "No pen and touch input is available for this display",
                    ImageUrl = "",
                    CategoryId = 1
                },
                new Computer
                {
                    ComputerId = 3,
                    Name = "C",
                    Price = 2450,
                    Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                    RAM = "32GB",
                    HardDisk = "",
                    SystemType = "64-bit operating system, x64-based processor",
                    PenAndTouch = "No pen and touch input is available for this display",
                    ImageUrl = "",
                    CategoryId = 2
                },
                new Computer
                {
                    ComputerId = 4,
                    Name = "D",
                    Price = 2000,
                    Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                    RAM = "32GB",
                    HardDisk = "",
                    SystemType = "64-bit operating system, x64-based processor",
                    PenAndTouch = "No pen and touch input is available for this display",
                    ImageUrl = "",
                    CategoryId = 4
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Acer", BrandUrl = "images/Brand/acer.jpg", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Category { CategoryId = 2, Name = "Samsung", BrandUrl = "images/Brand/samsung.jpg", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Category { CategoryId = 3, Name = "Lenovo", BrandUrl = "images/Brand/Lenovo.jfif", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Category { CategoryId = 4, Name = "Hp", BrandUrl = "images/Brand/Hp.png", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Category { CategoryId = 5, Name = "Dell", BrandUrl = "images/Brand/Dell.png", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Category { CategoryId = 6, Name = "Asus", BrandUrl = "images/Brand/asus.png", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." });

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    FirstName = "Wei",
                    LastName = "C",
                    PhoneNumber = "+12345678919",
                    Email = "za@a.gmail.com",
                    PostalCode = "888",
                    Street = "Möland",
                    City = "Goteborg",
                    Country = "Sweden"
                },
                new Customer
                {
                    CustomerId = 2,
                    FirstName = "Magnus",
                    LastName = "I",
                    PhoneNumber = "+12345678919",
                    Email = "ya@a.gmail.com",
                    PostalCode = "",
                    Street = "aaa",
                    City = "Skåne",
                    Country = "Sweden"
                },
                new Customer
                {
                    CustomerId = 3,
                    FirstName = "Muzdalifa",
                    LastName = "I",
                    PhoneNumber = "+99345678919",
                    Email = "xa@a.gmail.com",
                    PostalCode = "123",
                    Street = "Frostaliden",
                    City = "Skövde",
                    Country = "Sweden"
                },
                new Customer
                {
                    CustomerId = 4,
                    FirstName = "Seong",
                    LastName = "Gi-hun",
                    PhoneNumber = "+33345678919",
                    Email = "aa@a.gmail.com",
                    PostalCode = "123",
                    Street = "bbb",
                    City = "Uppsala",
                    Country = "Sweden"
                },
                new Customer
                {
                    CustomerId = 5,
                    FirstName = "Kang ",
                    LastName = "Sae-Byeok",
                    PhoneNumber = "+12345678919",
                    Email = "ba@a.gmail.com",
                    PostalCode = "345",
                    Street = "Hjo",
                    City = "Skövde",
                    Country = "Sweden"
                }
            );
        }
    }
}
