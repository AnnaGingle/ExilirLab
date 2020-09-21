using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static string title = "Exilir Lab";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Elixir Lab!");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            //this is a change


            //Create receipe object by using the instance constructor
            Receipe receipe1 = new Receipe("Fennel and Candied Ginger Elixir","Produces one exilir. Aids digestion","1 tablespoon candied ginger from receipe, 1 tablespoon dried orange peel powder, 3 tablespoons fennel seeds, and 3 cups water");
            Receipe receipe2 = new Receipe("Elderberry Elixir","Produces one elixir. Used to remedy cold symptoms.","1/2 cup dried sambucus nigra, 3 cups water, 1 cup honey");
            Receipe receipe3 = new Receipe(" Cold and Flu Elixir","Produces one elixir. Used to remedy cold and flu symptoms.","3 cups water, 1 ounce fresh ginger, 1/4 cup apple cider vinegar, 1/4 cup raw honey, 2 cinnamon sticks, 1/2 teaspoon cayenne pepper");
            Receipe receipe4 = new Receipe("","","");
            Receipe receipe5 = new Receipe("","","");
        }
    }
}
