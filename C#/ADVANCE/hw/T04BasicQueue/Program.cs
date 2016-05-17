using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04BasicQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            int queue = input[0];
            int dequeue = input[1];
            int theNum = input[2];

            Queue<int> data = new Queue<int>();

            int[] nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            foreach (var num in nums)
            {
                if (queue > 0)
                {
                    data.Enqueue(num);
                }
                queue--;
            }
            if (data.Count() > 0)
            {
                for (int i = 0; i < dequeue; i++)
                {
                    data.Dequeue();
                    if (data.Count() == 0)
                    {
                        break;
                    }
                }
                
            }

            if (data.Count > 0)
            {
                if (data.Contains(theNum))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(data.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
