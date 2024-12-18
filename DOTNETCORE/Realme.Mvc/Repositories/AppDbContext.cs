using Microsoft.EntityFrameworkCore;

using Realme.Mvc.Models;

namespace Realme.Mvc.Repositories
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
    }
}