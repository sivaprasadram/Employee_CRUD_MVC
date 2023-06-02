using Employee_CRUD_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_CRUD_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }

}

