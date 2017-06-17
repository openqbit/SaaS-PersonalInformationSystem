using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.PIS.Common.Models
{
    public class TaskDetail
    {
        public int ID { get; set; }
        public DateTime TaskDateAndTime { get; set; }

        public int TaskId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Task Task { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
