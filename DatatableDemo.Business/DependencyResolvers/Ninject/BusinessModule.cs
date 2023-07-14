using DatatableDemo.Business.Abstract;
using DatatableDemo.Business.Concrete.Managers;
using DatatableDemo.DataAccess.Abstract;
using DatatableDemo.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace DatatableDemo.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPhoneDal>().To<EfPhoneDal>().InSingletonScope();
            Bind<IPhoneService>().To<PhoneManager>().InSingletonScope();
        }
    }
}
