using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Receipe
    {



        //public Receipe()
        //{
        //  Title = "Fennel and Candied Ginger Elixir";
        // Description = "Produces one elixir. Aids digestion";
        //Ingredients = "1 tablespoon candied ginger from receipe, 1 tablespoon dried orange peel powder, 3 tablespoons fennel seeds, and 3 cups water."
        //}

        //constructors dont have return type
        //holds initionalization
        public Receipe (string receipeTitle, string receipeDescription, string receipeIngredients)
        {
            Title = receipeTitle;
            Description = receipeDescription;
            Ingredients = receipeIngredients;

        }


        public string Title { get; set; } // auto property with wide open encapslation
        public string Description { get; set; }
        public string Ingredients { get; set; }

    }
}
