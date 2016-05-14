using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP
{
    class Persons
    {
        static void Main()
        {

            Person koko = new Person("ivan", 44);
            Person boko = new Person("Boko", 33, "Bochko@abv.bg");


            Console.WriteLine(koko.ToString());
            Console.WriteLine(boko.ToString());
        }
    }
}
