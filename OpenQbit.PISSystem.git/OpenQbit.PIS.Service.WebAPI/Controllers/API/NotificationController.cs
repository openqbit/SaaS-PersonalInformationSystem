using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OpenQbit.PIS.Service.WebAPI.Controllers.API
{
    public class NotificationController : ApiController
    {
        /*
        public HttpResponseMessage Post(ApiInsuranceModel accident)
        {
            if (_insuranceManager.Recored(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Put(ApiInsuranceModel accident)
        {
            if (_insuranceManager.Update(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);

        }

        public HttpResponseMessage Delete(ApiInsuranceModel accident)
        {
            if (_insuranceManager.Delete(accident)) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public ApiInsuranceModel Get(ApiInsuranceModel accident)
        {
            /* ApiInsuranceModel insurance = new ApiInsuranceModel
             {
                 //ID = (int)ID,
                 //AgentID = 1,
                 //ClientID = 1,
                 //Joining_Date = new DateTime(2000, 02, 29),
                 //End_Date = new DateTime(2017, 02, 29),
                 //Total_Value = 1000000,
             };

             return insurance;*/

            //return _insuranceManager.Find<ApiInsuranceModel>(e => e.ID == accident.ID);
       // }

        //public List<ApiInsuranceModel> GetList()
        //{
            /*List<ApiInsuranceModel> InsuranceList = new List<ApiInsuranceModel>();
            ApiInsuranceModel insurance1 = new ApiInsuranceModel
            {
                //ID = 1,
                //AgentID = 1,
                //ClientID = 1,
                //Joining_Date = new DateTime(2000, 02, 29),
                //End_Date = new DateTime(2017, 02, 29),
                //Total_Value = 1000000,
            };
            InsuranceList.Add(insurance1);
            ApiInsuranceModel insurance2 = new ApiInsuranceModel
            {
                //ID = 2,
                //AgentID = 1,
                //ClientID = 1,
                //Joining_Date = new DateTime(2010, 02, 29),
                //End_Date = new DateTime(2020, 02, 29),
                //Total_Value = 1000000,
            };
            InsuranceList.Add(insurance2);
            return InsuranceList;*/

            //return _insuranceManager.GetAll<ApiInsuranceModel>();
        //}
        
    }
}