using DatatableDemo.Entities.Concrete;
using System.Collections.Generic;

namespace DatatableDemo.Business.Abstract
{
    public interface IPhoneService
    {
        IEnumerable<Phone> GetAll();
    }
}
