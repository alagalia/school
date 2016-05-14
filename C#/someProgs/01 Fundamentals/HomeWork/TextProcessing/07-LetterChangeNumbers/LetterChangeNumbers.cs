using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemLetterChangeNumbers
{
    class LetterChangeNumbers
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {' ','\t'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                double number = double.Parse(input[i].Substring(1, input[i].Length - 2));

                bool isUpper = false;
                bool isLower = false;
                int positionAtAlphabet = 0;

                if (input[i][0] >= 65 && input[i][0] <= 90)
                {
                    positionAtAlphabet = (int)input[i][0] - 64;
                    isUpper = true;
                }
                else
                {
                    positionAtAlphabet = (int)input[i][0] - 96;
                    isLower = true;
                }
                if (isUpper)
                {
                    result += number / positionAtAlphabet;
                }
                else
                {
                    result += number * positionAtAlphabet;
                }

                isUpper = false;
                isLower = false;

                if (input[i][input[i].Length - 1] >= 65 && input[i][input[i].Length - 1] <= 90)
                {
                    positionAtAlphabet = (int)input[i][input[i].Length - 1] - 64;
                    isUpper = true;
                }
                else
                {
                    positionAtAlphabet = (int)input[i][input[i].Length - 1] - 96;
                    isLower = true;
                }
                if (isUpper)
                {
                    result -= positionAtAlphabet;
                }
                else
                {
                    result += positionAtAlphabet;
                }
            }
            Console.WriteLine("{0:F2}",result);
        }
    }
}
