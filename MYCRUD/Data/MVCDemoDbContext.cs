using Microsoft.EntityFrameworkCore;
using MYCRUD.Models.Domain;

namespace MYCRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Technique> Techniques{ get; set; }
    }
}
