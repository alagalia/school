using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Pairs
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        int[] numbers = new int[input.Length];
        int lenghtOfsumOfNums = 0;

        //if (input.Length == 2)
        //{
        //    lenghtOfsumOfNums = 2;
        //}
        //else
        //{
        //    lenghtOfsumOfNums = input.Length / 2;
        //}

        int[] sumOfNums = new int[input.Length / 2];

        int j = 0;

        bool areEquals = false;

        int value = 0;

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);

            if (i % 2 != 0)
            {
                sumOfNums[j] = numbers[i] + numbers[i - 1];
                if (j != 0)
                {
                    areEquals = sumOfNums[j] == sumOfNums[j - 1];
                    value = sumOfNums[j];
                }
                j++;
            }
        }

        if (sumOfNums.Length == 1)
        {
            value = sumOfNums[0];
            areEquals = true;
        }
        if (areEquals )
        {
            Console.WriteLine("Yes, value={0}", value);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", sumOfNums.Max() - sumOfNums.Min());
        }

    }
}

