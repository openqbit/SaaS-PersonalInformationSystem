using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.PIS.Common.Models
{
   public class Message
    {
        public int ID { get; set; }
        public string MessageDescription { get; set; }
        public string MessageType { get; set; }
        public DateTime MessageDate { get; set; }
        public DateTime MessageTime { get; set; }

        public virtual ICollection<MessageDetail> MessageDetail { get; set; }
    }
}
