using System;

using System.Collections.Generic;

public class Employee
{
	public int ID { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public virtual Task Task { get; set; }


}
