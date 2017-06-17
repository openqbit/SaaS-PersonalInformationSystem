using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.PIS.Common.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Description { get; set; }

        //public int EmployeeId { get; set; }
        //public virtual Employee Employee { get; set; }

        public int TaskTypeId { get; set; }

        public virtual TaskType TaskType { get; set; }

        public virtual ICollection<TaskDetail> TaskDetail { get; set; }

    }
}
