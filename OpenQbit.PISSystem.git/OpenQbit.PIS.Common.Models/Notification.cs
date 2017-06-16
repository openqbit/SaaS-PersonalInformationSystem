using OpenQbit.PIS.Common.Models;
using System;

using System.Collections.Generic;

public class Notification
{
    public int ID { get; set; }

    public string Desc { get; set; }

    public string Date { get; set; }

    public string Time { get; set; }

    public virtual ICollection<Task> Task { get; set; }  //Test Comment


}
