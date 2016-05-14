using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class newHouse
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string ('-', num / 2 - i), new string ('*', 1 + 2*i ) );
        }
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("|{0}|", new string('*',num - 2));
        }
    }
}

