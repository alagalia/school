using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedNumber
{
    class ReversedNumber
    {
        static void Main()
        {
            //string number = "3.45";
            string number = Console.ReadLine();

            Console.WriteLine(GetReversedNum(number));
        }

        private static double GetReversedNum(string number)
        {
            double reversed = 0d;
            string revString = string.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                revString += number[i];
            }

            return reversed = double.Parse(revString);
        }
    }
}
