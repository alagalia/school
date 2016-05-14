using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArraySort
{
    class GenericArraySort
    {
        static void Main()
        {
            int[] numbers = { 1, 3, 7, 4, 2, 9, 0 };
            string[] words = { "koko", "boko", "apple", "juice", "car", "dog", "zombie" };
            DateTime[] dates = { new DateTime(2001, 3, 4), new DateTime(1998, 1, 8),
                                 new DateTime(2014, 5, 11), new DateTime(1982, 10, 6),
                                 new DateTime(2010, 11, 1), new DateTime(2020, 8, 22) };

            SortArray(numbers);
            SortArray(words);
            SortArray(dates);

        }

        private static void SortArray<T>(T [] numbers)
        {
            List<T> sortItems = new List<T>();

            for (int i = 0; i < numbers.Length; i++)
            {
                sortItems.Add(numbers[i]);
            }

            sortItems.Sort();

            //foreach (var item in sortItems)  // вече разбрах кога (иска да) работи string.join :)
            //{
            //    Console.Write("{0}", String.Join(", ", item));
            //}
            Console.WriteLine(string.Join(", ", sortItems));

        }
        
        
    }
}
