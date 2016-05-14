using System.Collections.Generic;

namespace ProbClassStudent
{
    public class Student
    {
        public Student (string firstName, string lastName, int age, string facultyNumber, string phone,
            string email, IList<int> marks, int groupNum, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNum = groupNum;
            this.GroupName = groupName;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultyNumber { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        public int GroupNum { get; set; }

        public string GroupName { get; set; }

        
    }
}
