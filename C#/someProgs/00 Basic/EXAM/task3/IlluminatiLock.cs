using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IlluminatiLock
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', num), new string('#', num));

        for (int i = 0; i < num / 2; i++)
        {
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}",  new string('.', num - 2 - 2*i), new string('.', i*2), new string ('.', num - 2));
        }
        for (int i = num / 2 - 1; i >= 0; i--)
        {
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', num - 2 - 2 * i), new string('.', i * 2), new string('.', num - 2));
        }

        Console.WriteLine("{0}{1}{0}", new string('.', num), new string('#', num));
    }
}

