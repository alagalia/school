using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04SULearningSystem
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string name, string lastName, int age) : base(name, lastName, age)
        {

        }

        public override void addCourse(string course)
        {
            base.addCourse(course);
        }

        public void delCourse(string course)
        {
            //this.Courses.Remove(course);
            Console.WriteLine("{0} has been removed from program !", course);
        }
    }
}
