using EducationalPractice.Models.Client;
using EducationalPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace EducationalPractice.Utils
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Service> Services { get; set; }
        public DbSet<ClientCorporate> ClientsCorporate { get; set; }
        public DbSet<ClientIndividual> ClientsIndividual { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
