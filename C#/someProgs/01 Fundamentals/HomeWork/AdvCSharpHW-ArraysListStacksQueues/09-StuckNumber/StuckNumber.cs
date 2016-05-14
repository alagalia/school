using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class StuckNumber
{
    static void Main()
    {
        int numberOfnumbers = int.Parse(Console.ReadLine());

        string[] numbers = Console.ReadLine().Split(' ').ToArray();

        List<string> possibleResult = new List<string>();

        SortedDictionary<string, string> result = new SortedDictionary<string, string>();

        int count = 0;

        if (numberOfnumbers > 3)
        {
            for (int a = 0; a < numberOfnumbers; a++)
            {
                for (int b = 0; b < numberOfnumbers; b++)
                {
                    for (int c = 0; c < numberOfnumbers; c++)
                    {
                        for (int d = 0; d < numberOfnumbers; d++)
                        {
                            if (a != b && a != c && a != d && b != c && b != d && c != d)
                            {
                                string firstCouple = numbers[a] + numbers[b];
                                string secondCouple = numbers[c] + numbers[d];

                                if (firstCouple == secondCouple)
                                {

                                    Console.WriteLine(numbers[a] + "|" + numbers[b] + "==" + numbers[c] + "|" + numbers[d]);
                                    count++;
                                }
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

        else
        {
            Console.WriteLine("No");
        }


        


    }

    
}

