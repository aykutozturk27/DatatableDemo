using DatatableDemo.Core.DataAccess.EntityFramework;
using DatatableDemo.DataAccess.Abstract;
using DatatableDemo.Entities.Concrete;

namespace DatatableDemo.DataAccess.Concrete.EntityFramework
{
    public class EfPhoneDal : EfEntityRepositoryBase<Phone, DatatableDemoContext>, IPhoneDal
    {
    }
}
