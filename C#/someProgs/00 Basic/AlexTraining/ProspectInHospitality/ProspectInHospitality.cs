using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectInHospitality
{
    class ProspectInHospitality
    {
        static void Main()
        {
            decimal builders = decimal.Parse(Console.ReadLine()) * 1500.04m;
            decimal receptionists = decimal.Parse(Console.ReadLine()) * 2102.10m;
            decimal chambermainds = decimal.Parse(Console.ReadLine()) * 1465.46m;
            decimal technicians = decimal.Parse(Console.ReadLine()) * 2053.33m;
            decimal others = decimal.Parse(Console.ReadLine()) * 3010.98m;

            decimal nikiSalary = decimal.Parse(Console.ReadLine());
            decimal usdCurrency = decimal.Parse(Console.ReadLine());
            decimal nikiUsdSalary = nikiSalary * usdCurrency;
            decimal baiShuraSalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal totalSalary = baiShuraSalary + nikiUsdSalary + others + technicians + chambermainds + receptionists + builders;

            Console.WriteLine("The amount is: {0:F2} lv.", totalSalary);

            if (totalSalary <= budget)
            {
                Console.WriteLine(@"YES \ Left: {0:F2} lv.", budget - totalSalary);
            }

            else
            {
                Console.WriteLine(@"NO \ Need more: {0:F2} lv.", totalSalary - budget);
            }
        }
    }
}
