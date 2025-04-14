
using CQRSMediatRDemos.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediatRDemos.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
