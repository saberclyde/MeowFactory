using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<String> meowList = new List<String>() { "meow", "mrraow", "mraow", "mrrraow", "mrrrraow", "meow", "meow", "maow", "maaaow", "meoww" };

            //CHANGE THIS STUFF
            bool format = false; // set to true if you want formatting
            int lineBreakFrequency = 8;
            int meowCount = random.Next(1, 100); // change random.Next(1, 100) to a number if you want a specific amount
            //====================

            for (int i = 0; i < meowCount; i++)
            {
                Console.Write(meowList[random.Next(meowList.Count)]); // choose a random meow
                if (i != meowCount - 1) Console.Write(" "); // insert spaces
                if (format && i % lineBreakFrequency == 0 && i != 0) Console.Write("\n"); // formatting
            }
            
            Console.ReadKey();
        }
    }
}
