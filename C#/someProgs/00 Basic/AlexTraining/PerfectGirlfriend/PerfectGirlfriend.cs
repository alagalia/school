using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectGirlfriend
{
    class PerfectGirlfriend
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int count = 0;
            int result = 0;

            while (input != "Enough dates!")
            {
                string[] data = input.Split('\\');
                result = 0;
                // day of week
                string dayOfWeek = data[0];
                switch (dayOfWeek)
                {
                    case "Monday":
                        result += 1;
                        break;
                    case "Tuesday":
                        result += 2;
                        break;
                    case "Wednesday":
                        result += 3;
                        break;
                    case "Thursday":
                        result += 4;
                        break;
                    case "Friday":
                        result += 5;
                        break;
                    case "Saturday":
                        result += 6;
                        break;
                    case "Sunday":
                        result += 7;
                        break;

                }

                // phone number
                string phoneNum = data[1];
                int phoneNumCalc = 0;

                for (int i = 0; i < phoneNum.Length; i++)
                {
                    phoneNumCalc += int.Parse(phoneNum[i].ToString());
                }

                result += phoneNumCalc;

                string bra = data[2];
                int braNum = int.Parse(bra.Substring(0, bra.Length - 1));
                char braSym = bra[bra.Length-1];
                int braResult = braNum * braSym;

                result += braResult;

                // gril name
                string girlName = data[3];
                char firstLetter = girlName[0];
                int girlNameCalc = firstLetter * girlName.Length;

                result -= girlNameCalc;

                // check

                if (result >= 6000)
                {
                    Console.WriteLine("{0} is perfect for you.", girlName );
                    count++;
                }
                else
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", girlName);
                }

                input = Console.ReadLine();
                //result = 0;
                //girlNameCalc = 0;
            }
            Console.WriteLine(count);
        }
    }
}
