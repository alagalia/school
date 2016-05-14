using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoko
{
    class sudoko
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int totalsec = 0;
            int totalGamesCount = 0;
            double aveerageSec = 0;
            while (command != "Quit")
            {
                string[] timesegment = command.Split(':');
                int min = int.Parse(timesegment[0]);
                int sec = int.Parse(timesegment[1]);
                totalsec = totalsec + 60 * min + sec;
                totalGamesCount++;

                command = Console.ReadLine();
            }

            aveerageSec = Math.Ceiling((double)totalsec / totalGamesCount);
            if (aveerageSec < 720)
            {
                Console.WriteLine("Gold Star");
            }
            else if (aveerageSec < 1400)
            {
                Console.WriteLine("Silver Star");
            }
            else
            {
                Console.WriteLine("Bronze Star");
            }
            Console.WriteLine(@"Games - {0} \ Average seconds - {1}",totalGamesCount, aveerageSec);
        }
    }
}
