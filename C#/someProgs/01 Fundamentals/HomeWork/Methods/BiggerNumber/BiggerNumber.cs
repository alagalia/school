using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class BiggerNumber
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            GetMaxAndPrint(firstNum, secondNum);
        }

        private static void GetMaxAndPrint(int firstNum, int secondNum)
        {
            int answer = Math.Max(firstNum, secondNum);
            Console.WriteLine(answer);
        }
    }
}
