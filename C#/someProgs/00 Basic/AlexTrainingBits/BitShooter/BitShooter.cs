using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShooter
{
    class BitShooter
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            //int[] fShot = int.Parse(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
            string[] firstShoot = Console.ReadLine().Split(' ');
            string[] secondShot = Console.ReadLine().Split(' ');
            string[] thirdShot = Console.ReadLine().Split(' ');
            string[] shoot = {firstShoot[0],firstShoot[1],secondShot[0],secondShot[1],thirdShot[0],thirdShot[1]};

            for (int i = 0; i < shoot.Length; i += 2)
            {
                int centar = int.Parse(shoot[i]);
                int lenght = int.Parse(shoot[i + 1]);
                int startIndex = centar - lenght / 2;
                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                int endIndex = centar + lenght / 2;
                if (endIndex > 63)
                {
                    endIndex = 63;
                }

                for (int j = startIndex; j <= endIndex; j++)
                {
                    ulong mask = 1ul;
                    ulong newNum = Convert.ToUInt64(number);
                    bool check = ((newNum >> j) & mask) == 1;
                    if (check)
                    {
                        number = newNum ^ (mask << j);
                        
                    }
                    
                }

            }
            int rightCount = 0;
            int leftCount = 0;
            for (int i = 0; i < 64; i++)
            {
                ulong mask = 1ul;
                bool check = ((number >> i) & mask ) == 1;
                if (check)
                {
                    if (i < 32)
                    {
                        rightCount++;
                    }
                    else
                    {
                        leftCount++;
                    }
                }

            }
            Console.WriteLine("left: {0}", leftCount);
            Console.WriteLine("right: {0}", rightCount);
        }
    }
}
