using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexercise
{
    public class Dog
    {
        string name;
        string breed;

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;

        }
        public Dog()
            : this(null, null)
        {

        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("{0} (breed: {1}) said: bau bau!!!", this.Name ?? "[unnamed dog]", this.Breed ?? "[unknown breed]");

        }
    }
}
