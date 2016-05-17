using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04SULearningSystem
{
    public class Person
    {
        private string name;
        private string lastName;
        private int age;

        public Person(string name, string lastName, int age)
        {
            this.Age = age;
            this.Name = name;
            this.LastName = lastName;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name must contain at least 1 char !");
                }
                this.name = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name must be at least 1 char.");
                }
                this.lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 110)
                {
                    throw new ArgumentOutOfRangeException("Age must be from 0 to 110");
                }
                this.age = value;
            }
        }
    }
}
