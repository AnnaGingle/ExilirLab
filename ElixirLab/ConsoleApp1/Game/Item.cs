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
    public int[] Amounts;
    public string Unit;
   

    public Item(string name, int v2, string unit)
    {
        this.Name = name;
        this.Amounts = amounts;
        this.Unit = unit;
    }

    public int[] amounts { get; }

    internal string Description()
    {
        throw new NotImplementedException();
    }
}
