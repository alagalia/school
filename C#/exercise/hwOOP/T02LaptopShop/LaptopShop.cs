using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02LaptopShop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Laptop moi = new Laptop("The best", 1000m);
            Console.WriteLine(moi);

            Battery bateriika = new Battery("AHK-45zr", 300000);

            Laptop negov = new Laptop("It's laptop", 500m, "mango-ze", "dimiat", 4, "super-muper-45", "slivova 450 TB", "plazma", bateriika);
            
            Console.WriteLine(negov);
            
            Console.WriteLine();
        }
    }
}
