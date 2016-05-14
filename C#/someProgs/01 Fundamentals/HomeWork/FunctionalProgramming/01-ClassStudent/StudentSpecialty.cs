using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbClassStudent
{
    public class StudentSpecialty
    {
        public StudentSpecialty (string specialtyName, string facNum)
        {
            this.SpecialtyName = specialtyName;
            this.FacNum = facNum;
        }
        public string SpecialtyName { get; set; }
        public string FacNum { get; set; }
    }
}
