using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04SULearningSystem
{
    public class Trainer : Person
    {
        private List<string> courses = new List<string>();

        public Trainer(string name, string lastName, int age) : base (name, lastName, age)
        {
            this.Courses = courses;
        }

        private List<string> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                //if (value == null)
                //{
                //    throw new ArgumentNullException("Course must be at least 2 character !");
                //}
                //this.courses = value;
            }
            
        }
        public virtual void addCourse(string course)
        {
            this.courses.Add(course);
            Console.WriteLine("Course '{0}' has been added to the program", course);
        }
        
    }
}
