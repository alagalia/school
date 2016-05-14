using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MagicDates
    {
        static void Main()
        {
            //int stYear = int.Parse(Console.ReadLine()); 
            string stYear = Console.ReadLine();
            DateTime startYear = DateTime.ParseExact(stYear , "yyyy", System.Globalization.CultureInfo.InvariantCulture);

            //int eYear = int.Parse(Console.ReadLine());
            string eYear = Console.ReadLine();
            DateTime endYear = DateTime.ParseExact(eYear, "yyyy", System.Globalization.CultureInfo.InvariantCulture);
            endYear = endYear.AddMonths(11).AddDays(30);
            //DateTime startYear = new DateTime(stYear, 1, 1);
            //DateTime endYear = new DateTime(eYear, 12, 31);

            int sumOfDate = 0;

            int magicWeight = int.Parse(Console.ReadLine());

            int count = 0;
            //

            //Console.WriteLine(begin);


            while (startYear <= endYear)
            {
                string begin = startYear.ToString("dd-MM-yyyy");
                

                begin = begin.Replace("-","");

                sumOfDate = 0;

                for (int i = 0; i < begin.Length - 1; i++)
                {
                    for (int j = i + 1; j < begin.Length; j++)
                    {
                        sumOfDate += (int)Char.GetNumericValue(begin[i]) * (int)Char.GetNumericValue(begin[j]);
                    }
                }

                if (sumOfDate == magicWeight)
                {
                    DateTime showData = startYear;
                    Console.WriteLine("{0:dd-MM-yyyy}",showData);
                    count++;
                }


                startYear = startYear.AddDays(1);
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }

        }
    }

