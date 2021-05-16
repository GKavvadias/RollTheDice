using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTheDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("=======================");
            Console.WriteLine("ROLLING A DICE 10 TIMES");
            Console.WriteLine("=======================");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 7) + " " + random.Next(1, 7));
                Console.WriteLine("-----------------------");
            }
            Console.ReadKey();
        }
    }
}
