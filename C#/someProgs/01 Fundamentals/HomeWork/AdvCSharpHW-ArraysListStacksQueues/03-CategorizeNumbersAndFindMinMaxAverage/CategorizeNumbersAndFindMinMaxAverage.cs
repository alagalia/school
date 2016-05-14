using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CategorizeNumbersAndFindMinMaxAverage
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ').ToArray();

        List<int> roundNums = new List<int>();
        List<double> floatingNums = new List<double>();

        foreach (var num in numbers)
        {
            double a = 0;
            a = double.Parse(num);
            bool isInt = a % 1 == 0;

            if (isInt)
            {
                roundNums.Add((int)a);
            }
            else
            {
                floatingNums.Add(a);
            }
        }

        Console.WriteLine("[{0}] -> min:{1}, max:{2}, sum:{3}, avg:{4:F2}",
            string.Join(", ", floatingNums), floatingNums.Min(),
            floatingNums.Max(), floatingNums.Sum(), floatingNums.Average());

        Console.WriteLine("[{0}] -> min:{1}, max:{2}, sum:{3}, avg:{4:F2}",
            string.Join(", ", roundNums), roundNums.Min(), roundNums.Max(),
            roundNums.Sum(), roundNums.Average());
       
    }
}

