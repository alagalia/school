using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximalSum
{
    static void Main()
    {
        int[] sizeOfMatrix = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[,] matrix = new int[sizeOfMatrix[0], sizeOfMatrix[1]];

        for (int i = 0; i < sizeOfMatrix[0]; i++)
        {
            int[] supportArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int j = 0; j < sizeOfMatrix[1]; j++)
            {
                matrix[i, j] = supportArray[j];
            }
        }


        // find biggest sum of 3x3

        int biggestSum = int.MinValue;
        int currentSum = 0;
        int[] starIndexOfSum = new int[2];

        for (int i = 0; i < sizeOfMatrix[0] - 2; i++)
        {
            for (int j = 0; j < sizeOfMatrix[1] - 2; j++)
            {
                currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                    + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                    + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                    starIndexOfSum[0] = i;
                    starIndexOfSum[1] = j;

                }
            }
        }


        // print the sum

        Console.WriteLine();

        Console.WriteLine("Sum = {0}\n", biggestSum);

        for (int i = starIndexOfSum[0]; i < starIndexOfSum[0] + 3; i++)
        {
            for (int j = starIndexOfSum[1]; j < starIndexOfSum[1] + 3; j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}

