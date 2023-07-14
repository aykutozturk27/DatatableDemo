using DatatableDemo.Business.Abstract;
using DatatableDemo.Business.DependencyResolvers.Ninject;
using DatatableDemo.Core.Entities.Datatable;
using System;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
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
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public static object GetData()
        {   
            string search = HttpContext.Current.Request.Params["search[value]"];
            int draw = Convert.ToInt32(HttpContext.Current.Request.Params["draw"]);
            string order = HttpContext.Current.Request.Params["order[0][column]"];
            string orderDir = HttpContext.Current.Request.Params["order[0][dir]"];
            int startRec = Convert.ToInt32(HttpContext.Current.Request.Params["start"]);
            int pageSize = Convert.ToInt32(HttpContext.Current.Request.Params["length"]);

            var phoneList = _phoneService.GetAll(); 
            
            int totalRecords = phoneList.Count();
            int recFilter = phoneList.Count();

            var resultList = phoneList.Skip(startRec).Take(pageSize).ToList();
            var result = new DataTableResponse(draw, resultList, recFilter, totalRecords);
            return result;
        }
    }
}