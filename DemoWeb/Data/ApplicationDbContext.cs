using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DemoWeb.Models;
using Microsoft.AspNetCore.Identity;

namespace DemoWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DemoWeb.Models.Category> Category { get; set; }
        public DbSet<DemoWeb.Models.Laptop> Laptop { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Seed data for user & role
            SeedUserRole(builder);

            //Seed data for table Category
            SeedCategory(builder);

            //Seed data for table Laptop
            SeedLaptop(builder);
        }

        private void SeedUserRole(ModelBuilder builder)
        {
            //A) Setup IdentityUser
            //1. Create accounts
            var adminAccount = new IdentityUser
            {
                Id = "admin-account",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true
            };

            var customerAccount = new IdentityUser
            {
                Id = "customer-account",
                UserName = "customer@gmail.com",
                Email = "cutomer@gmail.com",
                NormalizedUserName = "CUSTOMER@GMAIL.COM",
                NormalizedEmail = "CUSTOMER@GMAIL.COM",
                EmailConfirmed = true
            };

            //2. Declare hasher for password encryption
            var hasher = new PasswordHasher<IdentityUser>();

            //3. Setup password for accounts
            adminAccount.PasswordHash = hasher.HashPassword(adminAccount, "123456");
            customerAccount.PasswordHash = hasher.HashPassword(customerAccount, "123456");

            //4. Add accounts to database
            builder.Entity<IdentityUser>().HasData(adminAccount, customerAccount);

            //B) Setup IdentityRole
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "admin-role",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                 new IdentityRole
                 {
                    Id = "customer-role",
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                 });

            //C) Setup IdentityUserRole
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "admin-account",
                    RoleId = "admin-role"
                },
                new IdentityUserRole<string>
                {
                    UserId = "customer-account",
                    RoleId = "customer-role"
                }
             );
        }

        private void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
               new Category
               {
                   Id = 1,
                   Name = "Laptop gaming",
                   Description = "Laptop cho game thủ"
               },
               new Category
               {
                   Id = 2,
                   Name = "Laptop office",
                   Description = "Laptop cho dân văn phòng"
               },
               new Category
               {
                   Id = 3,
                   Name = "Laptop design",
                   Description = "Laptop cho dân thiết kế"
               }
           );
            // throw new NotImplementedException();
        }

        private void SeedLaptop(ModelBuilder builder)
        {
            builder.Entity<Laptop>().HasData(
                new Laptop
                {
                    Id = 1,
                    Name = "ASUS TUF Gaming",
                    Price = 1234.54,
                    Quantity = 10,
                    Image = "https://cdn2.cellphones.com.vn/insecure/rs:fill:358:358/q:90/plain/https://cellphones.com.vn/media/catalog/product/g/r/group_509_2__1.png",
                    CategoryId = 1
                },
                new Laptop
                {
                    Id = 2,
                    Name = "Dell XPS 13",
                    Price = 12356.54,
                    Quantity = 15,
                    Image = "https://nhatminhlaptop.com/upload/products/93801-2023-07-21-21-08-50.jpg",
                    CategoryId = 2
                },
                new Laptop
                {
                    Id = 3,
                    Name = "Lenovo LoQ",
                    Price = 1111.51,
                    Quantity = 12,
                    Image = "https://cdn2.fptshop.com.vn/unsafe/750x0/filters:quality(100)/2024_2_15_638435927047171103_lenovo-gaming-loq-15iax-9-i5-12450hx-led-trang-1.jpg",
                    CategoryId = 3
                }
            );
            //throw new NotImplementedException();
        }

    }
}
