using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineGlass
{
    class WineGlass
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num / 2; i++)
            {
                Console.Write(@"{0}\{1}/{0}", new string ('.', i), new string ('*', num - 2 - 2 * i));
                Console.WriteLine();
            }

            int rows = 0;

            if (num >= 12)
            {
                rows = num / 2 - 2;
            }
            else
            {
                rows = num / 2 - 1;
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("{0}| |{0}", new string ('.', num / 2 - 1));
            }
            Console.WriteLine("{0}", new string ('-', num));
            if (num >= 12)
            {
                Console.WriteLine("{0}", new string ('-', num));
            }
        }
    }
}
