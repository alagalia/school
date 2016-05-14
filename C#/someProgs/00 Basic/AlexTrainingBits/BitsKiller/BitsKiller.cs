using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsKiller
{
    class BitsKiller
    {
        static void Main()
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            byte[] numbers = new byte[numberOfNumbers];
            int index = 1;
            

            for (int i = 0; i < numberOfNumbers; i++)
            {
                numbers[i] = byte.Parse(Console.ReadLine());
            }

            string binNums = string.Empty;
            string finalBinNum = string.Empty;

            for (int i = 0; i < numberOfNumbers; i++)
            {
                binNums = binNums + Convert.ToString(numbers[i], 2).PadLeft(8,'0');
            }

            for (int i = 0; i < binNums.Length; i++)
            {
                if (index != i)
                {
                    finalBinNum = finalBinNum + binNums[i];
                }
                else
                {
                    index += step;
                }
                
            }

            int remainder = binNums.Length ;
            if (finalBinNum.Length == 8)
            {
                Console.WriteLine(Convert.ToInt16(finalBinNum, 2));
            }
            else
            {
                int x = finalBinNum.Length / 8 + 1;
                if (finalBinNum.Length % 8 != 0)
                {
                    finalBinNum = finalBinNum.PadRight(x * 8, '0');
                }
                
                remainder = finalBinNum.Length / 8;
                int[] newNum = new int[remainder];


                string a = string.Empty;
                int b = 0;
                int c = 0;

                for (int k = 0; k < finalBinNum.Length; k++)
                {

                    a = a + finalBinNum[k];
                    b++;
                    if (b == 8)
                    {

                        b = 0;
                        newNum[c] = Convert.ToInt16(a, 2);

                        Console.WriteLine(newNum[c]);
                        c++;
                        a = string.Empty;
                    }


                }
            }
            

            



            

        }
    }
}
