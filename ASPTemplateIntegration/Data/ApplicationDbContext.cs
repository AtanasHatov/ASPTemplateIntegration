using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASPTemplateIntegration.Models;

namespace ASPTemplateIntegration.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Customer>()
                .HasData(new Models.Customer[]
                {
                    new Customer
                    {
                        Id =1,FullName = "Иван Петров", Email = "ivan@example.com", RegisteredOn = new DateTime(2018,10,4)
                    },
                    new Customer {
                        Id=2,FullName = "Мария Димитрова", Email = "maria@example.com", RegisteredOn = new DateTime(2019,4,23)
                    },
                    new Customer {
                       Id=3, FullName = "Георги Георгиев", Email = "georgi@example.com", RegisteredOn = new DateTime(2025,5,2)
                    }
                });
            builder.Entity<Product>()
                .HasData(new Models.Product[] {
                    new Product {Id=1,Name = "Лаптоп Lenovo", Price = 1200, Description = "Бърз и надежден лаптоп за работа." },
                    new Product {Id=2,Name = "Мишка Logitech", Price = 45, Description = "Безжична мишка с добър захват." },
                    new Product{Id = 3, Name = "Монитор Samsung", Price = 320, Description = "Full HD дисплей 24 инча."}
                });
        }
    }
}
