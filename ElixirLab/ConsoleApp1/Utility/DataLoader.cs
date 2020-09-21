using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1.Utility
{
    class DataLoader
    {
        public static string LoadContent(string rList)
        {
            string Content = "";
            if (File.Exists(rList))
            {
                Content = File.ReadAllText(rList);
            }
            return Content;
        }

        public static void Pause()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
        }

    }
}
