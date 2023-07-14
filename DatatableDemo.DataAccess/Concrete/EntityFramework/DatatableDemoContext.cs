using DatatableDemo.Entities.Concrete;
using System.Data.Entity;

namespace DatatableDemo.DataAccess.Concrete.EntityFramework
{
    public class DatatableDemoContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DatatableDemoContext() : base("DatatableDemoDb")
        {
            Database.SetInitializer<DatatableDemoContext>(null);
        }
    }
}
