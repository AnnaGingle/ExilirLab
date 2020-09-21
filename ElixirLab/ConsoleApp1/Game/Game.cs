using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Game
{
    class Game
    {
        Player player;
        List<Receipe> rececipes = new List<Receipe>();
        public string Title;

        public Game()
        {
            SetUp();
            TitleScreen();

        }

        private void TitleScreen()
        {
            Title = "Easy App 2.0";

        }

        private void SetUp()
        {
            throw new NotImplementedException();
        }
    }

   
 
}
