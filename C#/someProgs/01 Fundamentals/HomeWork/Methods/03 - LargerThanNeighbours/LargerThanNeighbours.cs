using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            int[] numbers = { 1, 56, 23, 78, 23, 34, 2, 4, 7, 8, 345, 23, 789, 234, 54, 678, 2342 };
            //int[] numbers = { 3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }

        private static bool IsLargerThanNeighbours(int[] numbers, int i)
        {
            bool answer = false;

            int currentNum = numbers[i];
            if ((i - 1 < 0) || (i + 1 > numbers.Length - 1))
            {
                if ((i - 1 < 0) && (i + 1 > numbers.Length - 1))
                {
                    answer = true;
                }
                else if (i - 1 < 0)
                {
                    answer = numbers[i] > numbers[i + 1];
                }
                else
                {
                    answer = numbers[i] > numbers[i - 1];
                }
            }
            else
            {
                answer = numbers[i] > numbers[i + 1];
                answer = numbers[i] > numbers[i - 1];
            }

            return answer;
        }
    }
}
