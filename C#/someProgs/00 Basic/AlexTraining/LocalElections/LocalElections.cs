using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalElections
{
    class LocalElections
    {
        static void Main()
        {
            int candidates = int.Parse(Console.ReadLine());
            int voteChoice = int.Parse(Console.ReadLine());
            char voteSymbol = (char)Console.Read();

            for (int i = 1; i <= candidates; i++)
            {
                Console.WriteLine("{0}",new string('.', 13));
                Console.WriteLine("{0}+{1}+{0}",new string ('.', 3), new string('-', 5));
                if (voteChoice == i)
                {
                    if (voteSymbol.ToString().ToLower() == "x")
                    {
                        Console.WriteLine(@"...|.\./.|...");
                        Console.WriteLine(i.ToString().PadLeft(2,'0') + @".|..X..|...",i);
                        Console.WriteLine(@"...|./.\.|...");
                    }
                    else
	                {
                        Console.WriteLine(@"...|\.../|...");
                        Console.WriteLine(i.ToString().PadLeft(2,'0') + @".|.\./.|...");
                        Console.WriteLine("...|..V..|...");
	                }
                }
                else
                {
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine(i.ToString().PadLeft(2, '0') + ".|.....|...", i);
                    Console.WriteLine("...|.....|...");
                }
                Console.WriteLine("...+-----+...");

            }
            Console.WriteLine(".............");
        }
    }
}
