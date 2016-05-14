using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class CakeTycoon
{
    static void Main()
    {
        decimal cakeWants = decimal.Parse(Console.ReadLine());
        decimal kgOfFlourNeeded = decimal.Parse(Console.ReadLine());
        decimal kgOfFlourAcailable = decimal.Parse(Console.ReadLine());
        decimal truffles = decimal.Parse(Console.ReadLine());
        decimal priceOfOneTruffle = decimal.Parse(Console.ReadLine());

        decimal cakeMakes = kgOfFlourAcailable / kgOfFlourNeeded;
        decimal trufflesPrice = truffles * priceOfOneTruffle;
        decimal priceOfcake = (trufflesPrice / cakeWants) * 1.25M;
        decimal requiredFlour = (cakeWants * kgOfFlourNeeded) - kgOfFlourAcailable;





        if (cakeMakes < (decimal)cakeWants)
        {
            Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", Math.Floor(cakeMakes), requiredFlour);
        }
        else
        {
            Console.WriteLine("All products available, price of a cake: {0:F2}",priceOfcake);
        }

    }
}
