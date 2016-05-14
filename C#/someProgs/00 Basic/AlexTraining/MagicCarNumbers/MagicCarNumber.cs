using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCarNumbers
{
    class MagicCarNumber
    {
        static void Main()
        {
            int magicSum = int.Parse(Console.ReadLine());
            int[] letter = {10, 20, 30, 50, 80, 110, 130, 160, 200, 240};
            //'A'10, 'B'20, 'C'30, 'E'50, 'H'80, 'K'110, 'M'130, 'P'160,'T'200,'X'240
            int count = 40;
            for (int i = 0; i < 10000; i++)
            {
                int a = i;
                for (int j = 0; j < 10; j++)
                {
                    int b = letter[j];
                    for (int k = 0; k < 10; k++)
                    {
                        int c = letter[k];
                        if (count + i + b + k == magicSum )
                        {
                            count++;
                        }

                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
