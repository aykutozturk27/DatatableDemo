using DatatableDemo.Business.Abstract;
using DatatableDemo.Business.DependencyResolvers.Ninject;
using DatatableDemo.Core.Entities.Datatable;
using System;
using System.Linq;
using System.Web.Services;

namespace DatatableDemo.WebFormUI
{
    public partial class Phone : System.Web.UI.Page
    {
        private static IPhoneService _phoneService;
        protected void Page_Load(object sender, EventArgs e)
        {
            _phoneService = InstanceFactory.GetInstance<IPhoneService>();
        }

        [WebMethod]
        public static object GetData(DataTableRequest<Phone> model)
        {
            var phoneList = _phoneService.GetAll(); 
            var key = phoneList.Where(x => x.FirstName.ToLower().Contains(model.search.value)).ToList();
            var draw = model.draw;
            var start = model.start;
            var pageSize = model.length;
            
            int totalRecords = key.Count();
            int recFilter = key.Count();

            var resultList = key.Skip(start).Take(pageSize).ToList();
            var result = new DataTableResponse(draw, resultList, recFilter, totalRecords);
            return result;
        }
    }
}