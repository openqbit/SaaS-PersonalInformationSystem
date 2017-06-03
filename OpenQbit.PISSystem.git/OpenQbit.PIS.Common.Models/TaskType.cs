using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.PIS.Common.Models
{
    public class TaskType
    {
        private string ID { get; set; }
        private string TaskName { get; set; }
        private ICollection<TaskDetail> TaskDetail { get; set; }
    }
}
