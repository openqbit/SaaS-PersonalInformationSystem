using OpenQbit.PIS.BusinessService.Contracts;
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
    public class MessageController : ApiController
    {
        // GET: Message
        //public ActionResult Index()
        //{
        //    return View();
        //}
        IMessageManager _messageManager = UnityResolver.Resolve<IMessageManager>();

        public HttpResponseMessage Post(APIMessageModel messageM)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Put(APIMessageModel messageM)
        {
            return new HttpResponseMessage(HttpStatusCode.OK); ;
        }

        public HttpResponseMessage Delete(int? ID)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public APIMessageModel Get(int? ID)
        {

            return _messageManager.Find< APIMessageModel> (e => e.ID == ID);
        }

        public List<APIMessageModel> GetList()
        {

            return _messageManager.GetAll< APIMessageModel> ();
        }

    }
}