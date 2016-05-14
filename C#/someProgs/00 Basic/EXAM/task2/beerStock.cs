using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BeerStock
{
    static void Main()
    {
        ulong reservedBeers = ulong.Parse(Console.ReadLine());
        string comand = Console.ReadLine();
        ulong beers = 0;

        while (comand != "Exam Over")
        {
            string[] list = comand.Split(' '); 

            comand = Console.ReadLine();
            // beer = 1
            // sixPack = 6 * beer
            // case = 24 beer | 4 * sixpack
            // 
            for (int i = 1; i < list.Length; i += 2)
            {
                string type = list[i];

                switch (type)
                {
                    case "beers": beers += ulong.Parse(list[i - 1]);
                        break;
                    case "sixpacks": beers += 6 * ulong.Parse(list[i - 1]);
                        break;
                    case "cases": beers += 24 * ulong.Parse(list[i - 1]);
                        break;
                }
            }



        }

        ulong remainder = beers / 100;

        beers = beers - remainder;

        

        //

        if (beers >= reservedBeers )
        {
            beers = beers - reservedBeers;
            ulong cases = beers / 24;
            beers = beers - (cases * 24);

            ulong sixpacks = beers / 6;
            beers = beers - (sixpacks * 6);

            Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
        }
        else
        {
            ulong beersNeeded = reservedBeers - beers;
            ulong cases = beersNeeded / 24;
            beersNeeded = beersNeeded - (cases * 24);

            ulong sixpacks = beersNeeded / 6;
            beersNeeded = beersNeeded - (sixpacks * 6);

            Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beersNeeded);
        }
        //Console.WriteLine("a");
    }
}

