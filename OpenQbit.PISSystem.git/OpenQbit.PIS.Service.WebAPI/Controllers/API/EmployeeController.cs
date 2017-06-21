using OpenQbit.PIS.BusinessService.Contracts;
using OpenQbit.PIS.Common.Ioc;
using OpenQbit.PIS.Service.WebAPI.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace OpenQbit.PIS.Service.WebAPI.Controllers.API
{
    public class EmployeeController : ApiController
    {
        IEmployeeManager _employeeManager = UnityResolver.Resolve<IEmployeeManager>();

        public HttpResponseMessage Post(APIEmployeeModel employee)
        {
            if (_employeeManager.Recored(employee)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
        public HttpResponseMessage Put(APIEmployeeModel employee)
        {
            if (_employeeManager.Update(employee)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
        public HttpResponseMessage Delete(APIEmployeeModel employee)
        {
            if (_employeeManager.Delete(employee)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
        public APIEmployeeModel Get(int? ID)
        {
            return _employeeManager.Find<APIEmployeeModel>(e => e.ID == ID);
        }

        public List<APIEmployeeModel> GetList()
        {
            return _employeeManager.GetAll<APIEmployeeModel>();
        }
    }
}