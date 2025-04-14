using CQRSMediatRDemos.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediatRDemos.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Player> Players { get; set; }
    }

    public static class Extensions
    {
        public static void UseSeeder(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            DataSeeder.Seed(dbContext);
        }
    }

    public class DataSeeder
    {
        public static void Seed(AppDbContext dbContext)
        {
            if (dbContext.Employees.Any())
            {
                return;
            }
            dbContext.Employees.AddRange(Employees);
            dbContext.SaveChanges();
        }

        public static IEnumerable<Employee> Employees =>
        [
            new Employee {Name = "Saman", Email = "saman@domain.lk"},
            new Employee {Name = "Akila",Email = "Akila@domain.lk"},
            new Employee {Name = "Darshan",Email = "Darshan@domain.lk"},
            new Employee {Name = "Sugath",Email = "Sugath@domain.lk"},
            new Employee {Name = "Asela",Email = "Asela@domain.lk"},
            new Employee {Name = "Nirmal",Email = "Nirmal@domain.lk"},
            new Employee {Name = "Sheela",Email = "Sheela@domain.lk"},
            new Employee {Name = "Pavi",Email = "Pavi@domain.lk"},
            new Employee {Name = "Ashanya",Email = "Ashanya@domain.lk"}
        ];
    }

}
