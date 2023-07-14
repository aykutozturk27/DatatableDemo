using DatatableDemo.Core.DataAccess;
using DatatableDemo.Entities.Concrete;

namespace DatatableDemo.DataAccess.Abstract
{
    public interface IPhoneDal : IEntityRepository<Phone>
    {
    }
}
