using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCables
{
    class StudentCables
    {
        static void Main()
        {
            int numberOFCables = int.Parse(Console.ReadLine());
            int[] cables = new int[numberOFCables];
            int totalCables = 0;
            int count = 0;
            int fira = 0;

            for (int i = 0; i < numberOFCables; i++)
            {
                cables[i] = int.Parse(Console.ReadLine());
                string lengthUnit = Console.ReadLine();
                if (lengthUnit == "meters")
                {
                    cables[i] = cables[i] * 100;
                }
                if (cables[i] >= 20)
                {

                    if (cables[i] < 504)
                    {
                        totalCables += cables[i];
                        count++;
                    }
                    else
                    {
                        totalCables += cables[i];
                        count++;
                    }
                    
                    
                    
                }
                

            }
            
            int studentCables = (totalCables - ((count - 1) * 3)) / 504;
            int remainder = (totalCables - ((count - 1) * 3)) % 504;
            Console.WriteLine(studentCables);
            Console.WriteLine(remainder);

        }
    }
}
