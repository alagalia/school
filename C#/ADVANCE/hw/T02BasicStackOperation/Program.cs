using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace T02BasicStackOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] command = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            int push = command[0];
            int pop = command[1];
            int theNum = command[2];

            Stack<int> someNums = new Stack<int>();

            string pathern = @"\d+";
            Regex regex = new Regex(pathern);

            MatchCollection match = regex.Matches(Console.ReadLine());

            foreach (Match num in match)
            {
                if (push > 0)
                {
                    someNums.Push(int.Parse(num.Value));
                }
                push--;
            }

            if (someNums.Count() > 0)
            {
                for (int i = 0; i < pop; i++)
                {
                    someNums.Pop();
                    if (someNums.Count() == 0)
                    {
                        break;
                    }

                }
            }
            
            if (someNums.Contains(theNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (someNums.Count() == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(someNums.Min());
                }
                
            }
        }
    }
}
