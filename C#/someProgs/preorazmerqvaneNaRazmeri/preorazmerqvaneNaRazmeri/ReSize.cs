using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preorazmerqvaneNaRazmeri
{
    class ReSize
    {
        static void Main(string[] args)

        {
<<<<<<< HEAD
=======
            Console.OutputEncoding = Encoding.UTF8;
>>>>>>> 5fa856a0400e49e281581166e6596878a55bdc13
            Console.Write("Дебелина на кант (mm):");

            decimal kant = decimal.Parse(Console.ReadLine());
            kant /= 10m;

            Console.WriteLine();
            Console.WriteLine("1. Стари размери");
            Console.WriteLine("2. Нови размери");
            Console.Write("избор ( 1 / 2 ) : ");

            int  choice = int.Parse(Console.ReadLine());

            List<string> noviRazmeri = new List<string>();

            if (choice == 2)
            {

                Console.WriteLine();

                Console.Write("Въведи дължина и широчина:");

                String input = Console.ReadLine();
                

                while (input != "end")
                {
                    decimal[] razmeri = input.Split(' ').Select(decimal.Parse).ToArray();

                    ReSizee(kant, noviRazmeri, razmeri);
                    Console.Write("Въведи дължина и широчина:");
                    input = Console.ReadLine();
                }

                Console.WriteLine();

                PrintNewSize(noviRazmeri);
            }
            else
            {
<<<<<<< HEAD
                String[] oldDimmensions = new string[] 
                { 
=======
                String[] oldDimmensions = new string[] { 
>>>>>>> 5fa856a0400e49e281581166e6596878a55bdc13
                
                    "83.2 63.7",
                    "83.2 61.9",
                    "83.2 45",
                    "49.2 60",
                    "60.2 38.1",
                    "60.2 38.1",
                    "60.2 55",
                    "45.2 32.5",
                    "45.2 32.5"

                };

                for (int i = 0; i < oldDimmensions.Length; i++)
                {

                    decimal[] razmeri = oldDimmensions[i].Split(' ').Select(decimal.Parse).ToArray();

                    ReSizee(kant, noviRazmeri, razmeri);

                }

                PrintNewSize(noviRazmeri);


            }

            Console.WriteLine();

        }

        private static void PrintNewSize(List<string> noviRazmeri)
        {
<<<<<<< HEAD
=======
            Console.WriteLine();

>>>>>>> 5fa856a0400e49e281581166e6596878a55bdc13
            for (int i = 0; i < noviRazmeri.Count(); i++)
            {

                Console.WriteLine("{0}", noviRazmeri[i]);
            }
        }

        private static void ReSizee(decimal kant, List<string> noviRazmeri, decimal[] razmeri)
        {
            decimal height = razmeri[0];
            decimal width = razmeri[1];

            height -= 2 * kant;
            width -= 2 * kant;

            String orazmereni = height + " x " + width;

            noviRazmeri.Add(orazmereni);
        }
    }
}
