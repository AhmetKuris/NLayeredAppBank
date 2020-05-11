using System.Data.Entity;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        
        public DbSet<User> Users { get; set; }
    }
}
