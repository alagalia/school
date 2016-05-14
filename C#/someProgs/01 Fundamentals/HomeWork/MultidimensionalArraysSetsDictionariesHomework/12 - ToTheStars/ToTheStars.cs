using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ToTheStars
{
    static void Main()
    {
        string[] firstStar = Console.ReadLine().ToLower().Split(' ').ToArray();
        string[] secondStar = Console.ReadLine().ToLower().Split(' ').ToArray();
        string[] thirdStar = Console.ReadLine().ToLower().Split(' ').ToArray();

        double[] currentCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        int moves = int.Parse(Console.ReadLine());

        for (double x = currentCoordinates[0]; x <= currentCoordinates[0]; x++)
        {
            for (double y = currentCoordinates[1]; y <= currentCoordinates[1] + moves; y++)
            {
                bool fStarXY = ((x < (double.Parse(firstStar[1]) - 1)) ||
                               (x > (double.Parse(firstStar[1]) + 1))) ||
                               ((y < (double.Parse(firstStar[2]) - 1)) ||
                               (y > (double.Parse(firstStar[2]) + 1)));
                bool sStarXY = ((x < (double.Parse(secondStar[1]) - 1)) ||
                               (x > (double.Parse(secondStar[1]) + 1))) ||
                               ((y < (double.Parse(secondStar[2]) - 1)) ||
                               (y > (double.Parse(secondStar[2]) + 1)));
                bool tStarXY = ((x < (double.Parse(thirdStar[1]) - 1)) ||
                               (x > (double.Parse(thirdStar[1]) + 1))) ||
                               ((y < (double.Parse(thirdStar[2]) - 1)) ||
                               (y > (double.Parse(thirdStar[2]) + 1)));
                if (fStarXY && sStarXY && tStarXY)
                {
                    Console.WriteLine("space");
                }
                else if (fStarXY == false)
                {                   
                    Console.WriteLine(firstStar[0]);
                }
                else if (sStarXY == false)
                {
                    Console.WriteLine(secondStar[0]);
                }
                else
                {
                    Console.WriteLine(thirdStar[0]);
                }

            }
        }
    }
}

