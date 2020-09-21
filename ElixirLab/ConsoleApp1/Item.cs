using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Item
{
	public int Ammount { get; set; }

    private string name;

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        name = value;
    }

    public string Unit { get; set; }



	public Item()
	{
		//
		// TODO: Add constructor logic here
		//
		
	}

	public Item(string name, string unit, int ammount)
    {
        SetName(name);
		Unit = unit;
        Ammount = ammount;
    }
}
