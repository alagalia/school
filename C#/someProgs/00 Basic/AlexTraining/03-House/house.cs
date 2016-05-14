using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class House
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string ('.', number/2));
        //Console.WriteLine();
        for (int i = 0; i < number / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', number / 2 - 1 - i), new string('.', 1 + 2 * i));
        }
        Console.WriteLine("{0}", new string('*', number));
        for (int i = 0; i < number / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', number / 4),new string('.', number - 2 - number / 4 - number / 4));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', number / 4), new string('*',number - number/4 - number/4));
    }
}

