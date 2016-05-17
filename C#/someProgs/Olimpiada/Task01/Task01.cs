using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Task01
    {
        static void Main(string[] args)
        {

            long[] input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long fNum = input[0];
            long sNum = input[1];
            int count = 0;

            if (fNum <= sNum)
            {
                for (long i = fNum; i <= sNum; i++)
                {
                    long num = i;
                    string asBinary = Convert.ToString(num, 2);

                    StringBuilder reverse = stringReverse(asBinary);

                    if (asBinary == reverse.ToString())
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
            
        }

        private static StringBuilder stringReverse(string asBinary)
        {
            StringBuilder reverse = new StringBuilder();

            for (int j = asBinary.Length - 1; j >= 0; j--)
            {
                reverse.Append(asBinary[j]);
            }
            return reverse;
        }
    }
}
