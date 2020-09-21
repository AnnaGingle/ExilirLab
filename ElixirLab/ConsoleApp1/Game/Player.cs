using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Player
{
    public List<Item> Inventrory = new List<Item>();

	public Player()
	{
		//
		// TODO: Add constructor logic here
		//

	Inventrory.Add(new Item("White Flour", 4, "cup(s)"));
	Inventrory.Add(new Item("White Flour", 4, "cup(s)"));
	}

    public IEnumerable<Item> Inventory { get; private set; }

    public string ListInventoryItems()
  {
string temp = "Inventory:\n";
		int num = 1;
		foreach (Item i in Inventory) 
			{
			temp += num + ") " + i.Description() + "\n";
			num++;
        }
		return temp;
   }

}
