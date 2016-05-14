using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MasterHerbalist
{
    static void Main()
    {
        int dailyExpenses = int.Parse(Console.ReadLine());

        List<int> hours = new List<int>();
        List<string> herbs = new List<string>();
        List<int> priceForHerb = new List<int>();
        int count = 0;

        string input = Console.ReadLine();
        decimal money = 0;

        while (input != "Season Over")
        {
            

            string[] penka = input.Split(' ');



            for (int i = 0 ; i < penka.Length; i += 3)
            {
                hours.Add(int.Parse(penka[i]));
            }

            for (int j =  1; j < penka.Length; j += 3)
            {
                herbs.Add(penka[j]);
            }

            for (int i = 2; i < penka.Length; i+=3)
            {
                priceForHerb.Add(int.Parse(penka[i]));
            }

            for (int i = count; i < hours.Count; i++)
            {
                string her = herbs[i];
                int index = 0;

                for (int k = 0; k < hours[i]; k++)
                {
                    

                    if (her[index] == 'H')
                    {
                        money += priceForHerb[i];
                    }
                    index++;
                    if (index == her.Length )
                    {
                        index = 0;
                    }

                }
            }


            count++;

            input = Console.ReadLine();

        }
        decimal averageEarningPerDay = money / (decimal)count;

        if (averageEarningPerDay >= dailyExpenses )
        {
            Console.WriteLine("Times are good. Extra money per day: {0:F2}.", averageEarningPerDay - dailyExpenses);
        }
        else
        {
            Console.WriteLine("We are in the red. Money needed: {0:F0}.", Math.Floor((dailyExpenses * count)- money));
        }
    }
}

