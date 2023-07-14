using DatatableDemo.Business.Abstract;
using DatatableDemo.DataAccess.Abstract;
using DatatableDemo.Entities.Concrete;
using System.Collections.Generic;

namespace DatatableDemo.Business.Concrete.Managers
{
    public class PhoneManager : IPhoneService
    {
        private readonly IPhoneDal _phoneDal;

        public PhoneManager(IPhoneDal phoneDal)
        {
            _phoneDal = phoneDal;
        }

        public IEnumerable<Phone> GetAll()
        {
            return _phoneDal.GetList();
        }
    }
}
