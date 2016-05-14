using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuffleBits
{
    class shuffleBits
    {
        static void Main()
        {
            ulong firstNum = ulong.Parse(Console.ReadLine());
            ulong secondNum = ulong.Parse(Console.ReadLine());
            ulong result = 0;

            if (firstNum >= secondNum)
            {
                for (int i = 0; i < 31; i++)
                {
                    ulong mask = 1ul;
                    ulong firstNumBitValue = firstNum & (mask << i);
                    ulong secondNumBitValue = secondNum & (mask << i);

                    result = result | (secondNumBitValue << i);
                    result = result | (firstNumBitValue << (i + 1));
                }

            }
            else
            {
                for (int i = 0; i < 31; i += 2)
                {
                    ulong mask = 3ul;
                    ulong firstNumBitValue = firstNum & (mask << i);
                    ulong secondNumBitValue = secondNum & (mask << i);

                    result = result | (secondNumBitValue << i);
                    result = result | (firstNumBitValue << (i + 2));
                }
            }
            Console.WriteLine(result);
        }
    }
}
