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

    public string Name;
    public int Amounts;
    public string Unit;
   
    //Make list of ingredients with instances of type, amount, and unit
    public Item(string name, int amounts, string unit)
    {
        Name = name;
        Amounts = amounts;
        Unit = unit;
    }

}
