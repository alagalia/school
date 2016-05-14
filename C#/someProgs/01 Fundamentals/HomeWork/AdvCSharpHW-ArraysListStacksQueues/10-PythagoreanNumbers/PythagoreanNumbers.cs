using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PythagoreanNumbers
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        int[] numbers = new int[rows];

        int count = 0;

        for (int i = 0; i < rows; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                for (int k = 0; k < rows; k++)
                {
                    
                        if (numbers[i] <= numbers[j])
                        {
                            if (Math.Pow(numbers[i],2) + Math.Pow(numbers[j],2) == Math.Pow(numbers[k],2))
                            {
                                Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numbers[i], numbers[j], numbers[k]);
                                count++;
                            }
                        }
                    
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}

