using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01Person
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;

        }
        public Person(string name, int age)
            : this(name, age, null)
        {

        }

        public Person()
        {

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
                    throw new ArgumentNullException("Must contain at last 1 char !!!");
                }
                else
                {
                    this.name = value;
                }
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
                if (value > 0 && value <= 100)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age must be in range 1-100 !!!");
                }
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value != null && value.Contains("@"))
                {
                    this.email = value;
                }
                
            }
        }

        public override string ToString()
        {
            string message = string.Format("My name is {0} and I'm {1} years old. {2}",
                this.name, this.age, string.IsNullOrEmpty(this.email) ? "I have no email" :"My email is " + this.email);
            
            return message;
        }
    }
}
