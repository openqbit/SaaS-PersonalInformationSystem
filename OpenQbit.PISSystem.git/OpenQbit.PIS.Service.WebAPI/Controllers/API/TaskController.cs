using OpenQbit.PIS.BusinessService.Contracts;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.PIS.Service.WebAPI.Models.API;
using System.Net;
using OpenQbit.PIS.Common.Ioc;

namespace OpenQbit.PIS.Service.WebAPI.Controllers.API
{
    public class TaskController : ApiController
    {
        ITaskManager _taskManager = UnityResolver.Resolve<ITaskManager>();

        public HttpResponseMessage Post(APITaskModel document)
        {
            if (_taskManager.Recored(document)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(APITaskModel document)
        {
            if (_taskManager.Update(document)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Delete(APITaskModel document)
        {
            if (_taskManager.Delete(document)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public APITaskModel Get(int? ID)
        {
            return _taskManager.Find<APITaskModel>(e => e.ID == ID);
        }

        public List<APITaskModel> GetAll()
        {
            return _taskManager.GetAll<APITaskModel>();
        }
    }
}
        
    
