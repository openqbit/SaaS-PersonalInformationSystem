using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.PIS.Service.WebAPI.Models.API
{
    public class APINotificationModel
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public DateTime NotificationDate { get; set; }

        public virtual ICollection<Common.Models.Task> Task { get; set; }  //Test Comment
    }
}