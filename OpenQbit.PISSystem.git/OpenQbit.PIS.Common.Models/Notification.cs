using OpenQbit.PIS.Common.Models;
using System;

using System.Collections.Generic;

public class Notification
{
    public int ID { get; set; }

    public string Description { get; set; }

    public DateTime NotificationDate { get; set; }

    public virtual ICollection<Task> Task { get; set; }  //Test Comment


}
