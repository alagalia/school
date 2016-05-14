using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexercise
{
    class OOPExercise
    {
        static void Main()
        {
            Dog koko = new Dog("Koko", "Pudel");
            Dog unnamed = new Dog();

            unnamed.Name = "Boko";

            List<Dog> kuchkarnik = new List<Dog>();
            kuchkarnik.Add(koko);
            kuchkarnik.Add(unnamed);



            foreach (var dog in kuchkarnik)
            {
                dog.Bark();
            }
        }
    }
}
