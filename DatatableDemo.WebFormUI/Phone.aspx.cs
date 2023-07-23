using DatatableDemo.Business.Abstract;
using DatatableDemo.Business.DependencyResolvers.Ninject;
using DatatableDemo.Core.Entities.Datatable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using System.Web.UI;

namespace DatatableDemo.WebFormUI
{
    public partial class Phone : Page
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
            if (model.search.value != null)
            {
                phoneList = phoneList.Where(x => x.FirstName.ToLower().Contains(model.search.value)
                                        || x.LastName.ToLower().Contains(model.search.value)
                                        || x.Message.ToLower().Contains(model.search.value)
                                        || x.PhoneNumber.ToLower().Contains(model.search.value)).ToList();
            }

            IQueryable<Entities.Concrete.Phone> phoneQueryable = phoneList.AsQueryable();

            string sortColumn = model?.columns[model.order[0].column]?.name;
            string sortColumnDirection = model?.order?[0].dir;

            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                phoneList = phoneQueryable.OrderBy(x => sortColumn + " " + sortColumnDirection).ToList();

            var draw = model.draw;
            var start = model.start;
            var pageSize = model.length;

            int totalRecords = phoneList.Count();
            int recFilter = phoneList.Count();

            var resultList = phoneList.Skip(start).Take(pageSize).ToList();
            var result = new DataTableResponse(draw, resultList, recFilter, totalRecords);
            return result;
        }
    }
}