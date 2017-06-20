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
    public class NotificationController : ApiController
    {
        // GET: Notification
        //public ActionResult Index()
        //{
        //    return View();
        //}
        INotificationManager _notificationManager = UnityResolver.Resolve<INotificationManager>();

        public HttpResponseMessage Post(APINotificationModel notification)
        {
            if (_notificationManager.Recored(notification)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
        public HttpResponseMessage Put(APINotificationModel notification)
        {
            if (_notificationManager.Update(notification)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
        public HttpResponseMessage Delete(APINotificationModel notification)
        {
            if (_notificationManager.Delete(notification)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
        public APINotificationModel Get(int? ID)
        {
            return _notificationManager.Find<APINotificationModel>(e => e.ID == ID);
        }

        public List<APINotificationModel> GetList()
        {            
            return _notificationManager.GetAll<APINotificationModel>();
        }
    }
}