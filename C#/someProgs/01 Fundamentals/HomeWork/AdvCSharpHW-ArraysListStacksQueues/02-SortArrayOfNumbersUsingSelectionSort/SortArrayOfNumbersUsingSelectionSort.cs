using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbersUsingSelectionSort
{
    static void Main()
    {
        int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


        for (int i = 0; i < inputNumbers.Length; i++)
        {
            for (int j = 1; j < inputNumbers.Length; j++)
            {
                if (inputNumbers[j] < inputNumbers [j-1])
                {
                    int a = 0;
                    a = inputNumbers[j - 1];
                    inputNumbers[j - 1] = inputNumbers[j];
                    inputNumbers[j] = a;
                }
            }
        }
        Console.WriteLine(string.Join(", ",inputNumbers));
    }
}

