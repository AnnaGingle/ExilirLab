using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static ExilirLab..DataLoader;

namespace ConsoleApp1.Game
{
    class Game
    {
      
        List<Receipe> rececipes = new List<Receipe>();
        public string Title;

        public Game()
        {
            SetUp();
            TitleScreen();

        }

        private void TitleScreen()
        {
            

            string instructionFile = "Data/rText.txt";
            WriteLine(Utility.Interface.LoadContent(instructionFile));

            Pause();

        }

        private void SetUp()
        {
            throw new NotImplementedException();
        }
    }

   
 
}
