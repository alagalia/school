using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03PcCatalog
{
    class PcCatalog
    {
        static void Main()
        {
            Components gCard = new Components("radeon", "hd3990", 100m);
            Components gCard1 = new Components("nVidia", "gtx840m", 120.00m);
            Components cpu = new Components("amd", "phenom II x4 955", 130.00m);
            Components cpu1 = new Components("amd", "athlon x2 255", 87.5m);
            Components cpu2 = new Components("intel", "i3", 97m);
            Components cpu3 = new Components("intel", "i7", 340.2m);
            Components ram = new Components("dobra", "1600 mHz 1 gb", 40m);
            Components ram1 = new Components("biva", "1333 mHz 1 gb", 28.6m);
            Components ram2 = new Components("some", "800 mHz 2 gb", 20m);
            Components ram3 = new Components("some", "800 mHz 1 gb", 12m);
            Components sCard = new Components("sound Blaster", "super muper 100w", 130.7m);
            Components sCard1 = new Components("some", "mega 1000w", 63.2m);
            Components power = new Components("chinese", "super  700w", 76.1m);
            Components power1 = new Components("fortran", "550w", 183.2m);
            Components power2 = new Components("350w", 53.9m);

            PC first = new PC(cpu);
            PC second = new PC("good", cpu1);
            PC some = new PC("biva", gCard1, cpu3, ram, sCard, power1);

            first.addComponent(ram1);
            first.addComponent(ram1);
            second.addComponent(power2);
            second.addComponent(sCard);

            List<PC> data = new List<PC>();
            data.Add(first);
            data.Add(second);
            data.Add(some);

            data.Sort((x1, x2) => x2.Price.CompareTo(x1.Price));

            foreach (var komp in data)
            {
                Console.WriteLine(komp);
            }
        }
    }
}
