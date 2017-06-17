using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.PIS.Common.Models
{
    public class TaskType
    {
        public string ID { get; set; }
        public string TaskName { get; set; }
        public ICollection<Task> Task { get; set; }
    }
}
