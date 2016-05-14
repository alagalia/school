using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestTripple
{
    class BiggestTripple
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            int remainder = numbers.Length % 3;
            int sum = Int32.MinValue;
            int sum1 = Int32.MinValue;
            int sumToShow = Int32.MinValue;
            string numToShow = string.Empty;
            string numToShow1 = string.Empty;


            if (remainder == 0)
            {

                for (int i = 0; i < numbers.Length; i += 3)
                {
                    sum = int.Parse(numbers[i]) + int.Parse(numbers[i + 1]) + int.Parse(numbers[i + 2]);
                    if ((sum > sumToShow) || (int.Parse(numbers[i]) + int.Parse(numbers[i + 1]) + int.Parse(numbers[i + 2])) == 0 )
                    {
                        sumToShow = sum;
                        numToShow = numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2];
                    }
                }
            }
            else
            {
                if (numbers.Length > 2)
                {
                    sum = 0;
                    for (int i = 0; i < numbers.Length - remainder; i += 3)
                    {
                        sum = int.Parse(numbers[i]) + int.Parse(numbers[i + 1]) + int.Parse(numbers[i + 2]);
                        if (sum > sumToShow)
                        {
                            sumToShow = sum;
                            numToShow = numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2];
                        }
                    }
                    sum1 = 0;
                    for (int i = numbers.Length - remainder; i < numbers.Length; i++)
                    {
                        sum1 += int.Parse(numbers[i]);
                        numToShow1 = numToShow1 + numbers[i] + " ";
                    }
                }
                else
                {
                    sum1 = 0;
                    for (int i = numbers.Length - remainder; i < numbers.Length; i++)
                    {
                        sum1 += int.Parse(numbers[i]);
                        numToShow1 = numToShow1 + numbers[i] + " ";
                    }
                }
            }
            
                        
                

            if (sumToShow >= sum1)
            {
                Console.WriteLine(numToShow);
            }
            else
            {
                Console.WriteLine(numToShow1);
            }
            

        }
    }
}
