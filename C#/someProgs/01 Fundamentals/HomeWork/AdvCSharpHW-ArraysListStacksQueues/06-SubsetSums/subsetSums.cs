
using System;
using System.Collections.Generic;
using System.Linq;

    class SubsetSums
    {
        static void Main()
        {
            //int theSum = int.Parse(Console.ReadLine());
            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();

            //List<int> subsetSum = new List<int>();
            //int combinations = (int)Math.Pow(2, numbers.Length);

            //bool isEqual = false;

            //for (int i = 1; i < combinations; i++)
            //{
            //    int sum = 0;
            //    for (int j = 0; j < numbers.Length; j++)
            //    {
            //        int mask = i & (1 << j);
            //        if (mask != 0)
            //        {
            //            sum += numbers[0 + j];
            //            subsetSum.Add(numbers[0 + j]);
            //        }
            //    }

            //    if (sum == theSum)
            //    {
            //        Console.WriteLine(string.Join(" + ", subsetSum) + " = " + sum);
            //        isEqual = true;
            //    }

            //    //subsetSum.Clear();
            //}

            //if (!isEqual)
            //{
            //    Console.WriteLine("No matching subsets.");
            //}
            int a = int.Parse(Console.ReadLine());
            Fib(a);
            Console.WriteLine();
        }
        static long Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }

     

