using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiada
{
    class Task00
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                BigInteger someNum = num;

                for (int i = 0; i < num - 1 ; i++)
                {
                    someNum *= num;
                }

                String asText = someNum.ToString();

                if (num > asText.Length)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine(asText[num - 1]);
                }


                
            }
        }
    }
}
