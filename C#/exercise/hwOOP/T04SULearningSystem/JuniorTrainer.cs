using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04SULearningSystem
{
    public class JuniorTrainer : Trainer
    {
        public JuniorTrainer(string name, string lastName, int age):base(name, lastName, age)
        {

        }

        public override void addCourse(string course)
        {
            base.addCourse(course);
        }
    }
}
