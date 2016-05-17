using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03MaxElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            Stack<long> data = new Stack<long>();

            //List<int> myWay = new List<int>();

            if (nLines >= 1 && nLines <= 105)
            {
                for (int i = 0; i < nLines; i++)
                {
                    long[] input = Console.ReadLine().Trim().Split(new char [] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

                    if (input.Length == 1)
                    {
                        if (input[0] == 2)
                        {
                            if (data.Count() > 0)
                            {
                                data.Pop();
                            }
                        }
                        if (input[0] == 3)
                        {
                            Console.WriteLine(data.Max());
                            //myWay.Add(data.Max());
                        }
                    }
                    else
                    {
                        if (input[0] == 1)
                        {
                            if (input[1] >= 1 && input[1] <= 109)
                            {
                                data.Push(input[1]);
                            }
                        }
                        //if (input[0] == 2)
                        //{
                        //    if (data.Count() > 0)
                        //    {
                        //        data.Pop();
                        //    }
                        //}
                        //if (input[0] == 3)
                        //{
                        //    Console.WriteLine(data.Max());
                        //    //myWay.Add(data.Max());
                        //}
                    }
                }
            }
            //Console.WriteLine();
            //foreach (var num in myWay)
            //{
            //    Console.WriteLine(num);
            //}
        }
    }
}
