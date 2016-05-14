using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideTheBuilding
{
    class InsideTheBuilding
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            string answer = "outside";
            int[] coordinates = new int[10];
            for (int i = 0; i < 10; i++)
            {
                coordinates[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i += 2)
            {
                answer = "outside";
                bool x = ((coordinates[i] >= 0 && coordinates[i] <= h * 3));
                bool y = ((coordinates[i + 1] >= 0 && coordinates[i + 1] <= h));
                bool xx = ((coordinates[i] >= h && coordinates[i] <= h * 2));
                bool yy = ((coordinates[i + 1] >= 0 && coordinates[i + 1] <= h * 4));


                if ((x && y) || (xx && yy))
                {
                    answer = "inside";
                    Console.WriteLine(answer);
                }
                
                //if (xx && yy)
                //{
                //    answer = "inside";
                //    Console.WriteLine(answer);
                //}
                else
                {
                    Console.WriteLine(answer);
                }

            }
            

        }
    }
}
