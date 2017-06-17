using OpenQbit.PIS.Common.Models;
using System;

using System.Collections.Generic;

public class Employee
{
	public int ID { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public virtual ICollection<Task> Task { get; set; }  // Test Comment


}
