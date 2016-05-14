using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestIncreasingSequence
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        string supportString = string.Empty;
        string longestIncSequence = string.Empty;


        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("{0} ", numbers[i]);
                supportString = supportString + Convert.ToString(numbers[i]);

            }
            else if (numbers[i] > numbers[i - 1])
            {
                Console.Write("{0} ", numbers[i]);
                supportString = supportString + " " + Convert.ToString(numbers[i]);

            }
            else
            {
                if (supportString.Length > longestIncSequence.Length)
                {
                    longestIncSequence = supportString;
                    supportString = string.Empty;
                }
                supportString = string.Empty;
                Console.WriteLine();
                Console.Write("{0} ", numbers[i]);
                supportString = supportString + Convert.ToString(numbers[i]);
            }
        }

        if (supportString.Length > longestIncSequence.Length)
        {
            longestIncSequence = supportString;
            supportString = string.Empty;
        }
        Console.WriteLine("\r\n");

        Console.WriteLine(longestIncSequence);




        //var result = from num in numbers
        //             from num1 in numbers
        //             where num < num1
        //             group num1 by num
        //                 into newNumGroup
        //                 selectMany newNumGroup;

        //var result = from num in numbers
        //             from num1 in numbers.SelectMany(num, num1)
        //             where num < num1


        //// from num1 in numbers
        ////Console.WriteLine();

        //foreach (var group in result)
        //{
        //    foreach (var nums in group)
        //    {
        //        Console.Write("{0} ", nums);
        //    }
        //    Console.WriteLine();
        //}
        
        
        

    }
}

