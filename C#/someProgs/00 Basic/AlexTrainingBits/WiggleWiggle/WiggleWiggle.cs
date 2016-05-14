using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiggleWiggle
{
    class WiggleWiggle
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');


            for (int i = 0; i < input.Length; i += 2)
            {
                for (int j = 0; j < 64; j += 2)
                {
                    long mask = 1l;

                    long number1 = Convert.ToInt64(input[i]);
                    long number2 = Convert.ToInt64(input[i + 1]);

                    long input1 = 0l;
                    long input2 = 0l;

                    input1 = (number1 >> j) & mask;
                    input2 = (number2 >> j) & mask;

                    if (input1 != input2)
                    {
                        if (input1 == 1)
                        {
                            number1 = number1 ^ (mask << j);
                            number2 = number2 ^ (mask << j);
                            input[i] = number1.ToString();
                            input[i + 1] = number2.ToString();
                        }
                        else
                        {
                            number1 = number1 ^ (mask << j);
                            number2 = number2 ^ (mask << j);
                            input[i] = number1.ToString();
                            input[i + 1] = number2.ToString();
                        }

                    }
                }
            }
            //string[] bitNum = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < 63; j++)
                {
                    long mask = 1l;
                    long xNum = Convert.ToInt64(input[i]);
                    xNum = xNum ^ (mask << j);
                    input[i] = xNum.ToString();

                }

            }

            foreach (var number in input)
            {
                long num = long.Parse(number);
                Console.WriteLine("{0} {1}", number, Convert.ToString(num, 2));
            }
        }
    }
}
