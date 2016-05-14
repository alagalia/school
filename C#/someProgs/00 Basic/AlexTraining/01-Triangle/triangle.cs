using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main()
        {
            int ax = int.Parse(Console.ReadLine());
            int ay = int.Parse(Console.ReadLine());
            int bx = int.Parse(Console.ReadLine());
            int by = int.Parse(Console.ReadLine());
            int cx = int.Parse(Console.ReadLine());
            int cy = int.Parse(Console.ReadLine());

            double ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
            double bc = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
            double ca = Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2));

            bool firstSide = ab + bc > ca;
            bool secondSide = bc + ca > ab;
            bool thirdSide = ca + ab > bc;

            bool isTriangle = firstSide && secondSide && thirdSide;

            double areaTriangle = 0;


            if (isTriangle)
            {
                double halfPerimetar = (ab + bc + ca) / 2;

                areaTriangle = Math.Sqrt(halfPerimetar * (halfPerimetar - ab)*(halfPerimetar - bc) * (halfPerimetar - ca));

                Console.WriteLine("Yes");
                Console.WriteLine("{0:F2}", areaTriangle);

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}", ab);
            }
        }
    }
}
