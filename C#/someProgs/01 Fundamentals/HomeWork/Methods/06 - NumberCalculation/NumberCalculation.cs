using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCalculation
{
    class NumberCalculation
    {
        static void Main()
        {
            //decimal[] numbers = new decimal[] { 23, 2345, 467, 234, 677, 3, 4 };
            decimal[] numbers = new decimal[] { 1, 2, 3, 4, 5 };
            //double[] numbers = new double[] { 23.2, 2345.7, 467.3, 234.5, 677.9, 3.3, 4 };
            NumCalc(numbers);
        }

        private static void NumCalc(decimal[] numbers)
        {
            decimal min = decimal.MaxValue;
            decimal max = decimal.MinValue;
            decimal ave = 0;
            decimal sum = 0;
            decimal product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                sum += numbers[i];
                product *= numbers[i];
            }

            ave = sum / numbers.Length;

            Console.WriteLine("max number is: {0}",max);
            Console.WriteLine("min number is: {0}", min);
            Console.WriteLine("average value of  numbers is: {0}", ave);
            Console.WriteLine("sum of numbers are : {0}", sum);
            Console.WriteLine("product of numbers is : {0}", product);
        }
        private static void NumCalc(double[] numbers)
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            double ave = 0;
            double sum = 0;
            double product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                sum += numbers[i];
                product *= numbers[i];
            }

            ave = sum / numbers.Length;

            Console.WriteLine("max number is: {0}", max);
            Console.WriteLine("min number is: {0}", min);
            Console.WriteLine("average value of  numbers is: {0}", ave);
            Console.WriteLine("sum of numbers are : {0}", sum);
            Console.WriteLine("product of numbers is : {0}", product);
        }
    }
}
