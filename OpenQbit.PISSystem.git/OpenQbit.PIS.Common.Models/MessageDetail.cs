using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.PIS.Common.Models
{
    public class MessageDetail
    {
        public int ID { get; set; }
        public bool StatusEmail{ get; set; }
        public bool StatusInternalEmail { get; set; }
        public bool StatusSMS { get; set; }
        public int EmployeeID { get; set; }
        public int MessageID { get; set; }

        public virtual Message Message { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
