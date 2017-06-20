using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.PIS.Service.WebAPI.Models.API
{
    public class APITaskModel
    {
        public int ID { get; set; }
        public string Description { get; set; }

        //public int EmployeeId { get; set; }
        //public virtual Employee Employee { get; set; }

        public int TaskTypeId { get; set; }

        public virtual Common.Models.TaskType TaskType { get; set; }

        public virtual ICollection<Common.Models.TaskDetail> TaskDetail { get; set; }
    }
}