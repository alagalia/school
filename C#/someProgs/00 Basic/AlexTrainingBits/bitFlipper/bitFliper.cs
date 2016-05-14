using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitFlipper
{
    class bitFliper
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            List<int> aStartEndIndex = new List<int>();
            List<int> bStartEndIndex = new List<int>();

            // for 000
            for (int i = 63; i > 1; i--)
            {
                bool aa = ((number >> i) & 1) == 0;
                bool ab = ((number >> i - 1) & 1)== 0;
                bool ac = ((number >> i - 2) & 1) == 0;

                bool areZeroes = aa && ab && ac;

                if (areZeroes)
                {
                    aStartEndIndex.Add(i);
                    aStartEndIndex.Add(i - 2);
                    i -= 2;
                }              
            }

            // for 111
            for (int i = 63; i > 1; i--)
            {
                bool aa = ((number >> i) & 1) == 1;
                bool ab = ((number >> i - 1) & 1) == 1;
                bool ac = ((number >> i - 2) & 1) == 1;

                bool areZeroes = aa && ab && ac;

                if (areZeroes)
                {
                    bStartEndIndex.Add(i);
                    bStartEndIndex.Add(i - 2);
                    i -= 2;
                }
            }

            
            for (int i = 0; i < aStartEndIndex.Count; i+=2)
            {
                int num = 0;
                ulong mask = 1ul;
                num = aStartEndIndex[i];
                number = number | (mask << num);
                number = number | (mask << num - 1);
                number = number | (mask << num - 2);

            }
            for (int i = 0; i < bStartEndIndex.Count; i += 2)
            {
                int num = 0;
                ulong mask = 1ul;
                num = bStartEndIndex[i];
                number = number ^ (mask << num);
                number = number ^ (mask << num - 1);
                number = number ^ (mask << num - 2);

            }

            //ulong outputNum = 0ul;
            Console.WriteLine(number);
            
        }
    }
}
