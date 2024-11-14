using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EducationalPractice.Models;

namespace EducationalPractice.Utils.Extensions
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("MyDatabaseConnectionString") // Название строки подключения
        {

        }

        public DbSet<EmployeeCopy> Employees { get; set; } // Таблица Clients
    }
}
