using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class Program
    {
        static void Main()
        {
            int[] someNums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            foreach (var num in someNums)
            {
                stack.Push(num);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
