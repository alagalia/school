using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04SULearningSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            JuniorTrainer ivan = new JuniorTrainer("Ivan", "Ivanov", 34);
            ivan.addCourse("Math");
            //Console.WriteLine(ivan.Courses.Count);
            //ivan.Courses.Remove("Math");
            //Console.WriteLine(ivan.Courses.Count);
            SeniorTrainer koko = new SeniorTrainer("Kostadin", "Petrov", 40);
        }
    }
}
