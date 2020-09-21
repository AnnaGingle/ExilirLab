using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Receipe
    {

        public string Name;
        public string Description;
        public List<Item> Ingredients;
        public int[] Amounts;
      


        //public Receipe()
        //{
        //  Title = "Fennel and Candied Ginger Elixir";
        // Description = "Produces one elixir. Aids digestion";
        //Ingredients = "1 tablespoon candied ginger from receipe, 1 tablespoon dried orange peel powder, 3 tablespoons fennel seeds, and 3 cups water."
        //}

        //constructors dont have return type
        //holds initionalization
        public Receipe (string name, string description, List<Item> ingredients)
        {
            Name = name;
            Description = description;
            Ingredients = ingredients;
            
        }

    }
}
