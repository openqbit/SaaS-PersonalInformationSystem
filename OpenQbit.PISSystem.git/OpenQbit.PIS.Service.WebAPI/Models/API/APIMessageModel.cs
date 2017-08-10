using OpenQbit.PIS.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.PIS.Service.WebAPI.Models.API
{
    public class APIMessageModel
    {
        public int ID { get; set; }
        public string MessageDescription { get; set; }
        public DateTime MessageDate { get; set; }
        public DateTime MessageTime { get; set; }

        public virtual ICollection<MessageDetail> MessageDetail { get; set; }
    }
}