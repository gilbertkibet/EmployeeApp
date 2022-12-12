using EmployeeRestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeRestApi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options ) : base( options ) 
        {

        }

        public DbSet<Employee> EmployeeTable { get; set; }
    }
}
