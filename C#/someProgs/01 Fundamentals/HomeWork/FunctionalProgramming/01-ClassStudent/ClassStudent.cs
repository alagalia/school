using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbClassStudent
{
    public class ClassStudent
    {
        public static void Main()
        {
            var myStudents = new List<Student>
            {
                new Student("Milena", "Kirova", 23, "215314", "+35924557", "ivan@ivanov.bg", new List<int> { 3, 4, 5 }, 1, "PHP"),
                new Student("Stefan", "Popov", 21, "203114", "+45657345", "fhjgd@abv.bg", new List<int> {5,2,2}, 2, "Basic"),
                new Student("Asya", "Manova", 22, "203314", "+34565456", "ghvbn@ivanov.bg", new List<int> { 6,4,3}, 3, "Front-End"),
                new Student("Diana", "Petrova", 28, "203914", "+35987801", "sfrrefg@ivanov.bg", new List<int> { 3, 4, 5 }, 1, "Front-End"),
                new Student("Ivan", "Ivanov", 23, "203814", "+345667564", "eryrjfbd@abv.bg", new List<int> { 5,4,3}, 2, "PHP"),
                new Student("Orlin", "Orlinov", 21, "411567", "+359 236665", "gdvcvb@ivanov.bg", new List<int> { 2,6,2}, 3, "Basic"),
                new Student("Jivko", "Jivkov", 19, "451114", "+3464574", "wert45gdf@ivanov.bg", new List<int> { 4,2,3}, 1, "Front-End"),
                new Student("Qsen", "Qsenov", 34, "311453", "+3454645", "sdd5gdf@ivanov.bg", new List<int> { 4,6,3}, 2, "PHP"),
                new Student("Kalina", "Kalinova", 24, "811636", "+45756875", "ivcvfhfan@ivanov.bg", new List<int> {5,5,5}, 3, "Basic"),
                new Student("Malina", "Malinova", 16, "112469", "02 3564564", "dfgrtgd@ivanov.bg", new List<int> { 6,2,3}, 1, "Front-End"),
                new Student("Iordan", "Iordanov", 31, "119636", "+359 24745", "dfgjyjf@ivanov.bg", new List<int> {4,5,3 }, 2, "Back-End"),
                new Student("Hristo", "Doichev", 27, "311695", "+345546457", "dfgegdg@ivanov.bg", new List<int> {6,6,4 }, 3, "PHP"),
                new Student("Viaria", "Velikova", 26, "711914", "+2353463", "sefsfsdf@abv.bg", new List<int> { 5,3,2 }, 1, "Basic"),
                new Student("Never", "Nevenov", 31, "511864", "+2343453", "seftj6r5@ivanov.bg", new List<int> {3,5,4}, 2, "Front-End"),
                new Student("Dido", "Donchev", 21, "571195", "+359243634", "55hdfgd@ivanov.bg", new List<int> {4,4,2}, 3, "Back-End"),
                new Student("Mitko", "Dimitrov", 20, "211574", "+2353453", "dgfdgf@ivanov.bg", new List<int> {3,4,3}, 1, "Back-End"),
                new Student("Filip", "Filipov", 19, "381152", "+234346357", "dghdd@abv.bg", new List<int> {3,6,4 }, 2, "PHP"),
                new Student("Avren", "Mirchev", 18, "064116", "02 6645643", "dfgergd@ivanov.bg", new List<int> {4,5,6 }, 3, "Basic"),
                new Student("Cvetan", "Cvetanov", 19, "511683", "+345475787", "drgdfgd@ivanov.bg", new List<int> { 6,5,4, }, 2, "Front-End"),

            };
            

            // Problem 2 - sort by Group   ??????????????????????????????????????????????????????????????????

            //var sortByGroup = from student in myStudents
            //                  orderby student.FirstName
            //                  orderby student.GroupNum
            //                  group student by student.GroupNum;


            //foreach (var group in sortByGroup)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var students in group)
            //    {
            //        Console.WriteLine("{0} {1} age: {2} facultyNum: {3} phone: {4} email: {5} marks : {6}   group: {7}",
            //            students.FirstName, students.LastName, students.Age, students.FacultyNumber, students.Phone,
            //            students.Email, string.Join(", ", students.Marks), students.GroupNum);
            //    }
            //}
           

            //foreach (var group in sortByGroup)
            //{
            //    //Console.WriteLine(group.Key);
            //    foreach (var students in group)
            //    {
            //        if (students.GroupNum == 2)
            //        {
            //            Console.WriteLine("{0} {1} age: {2} facultyNum: {3} phone: {4} email: {5} marks : {6}   group: {7}",
            //            students.FirstName, students.LastName, students.Age, students.FacultyNumber, students.Phone,
            //            students.Email, string.Join(", ", students.Marks), students.GroupNum);
            //        }                    
            //    }
            //}








            // first before last 03 
            //Console.WriteLine();

            //var firstBeforeLast = from student in myStudents
            //                      where student.FirstName.CompareTo(student.LastName) < 0
            //                      select student;

            //foreach (var students in firstBeforeLast)
            //{
            //    Console.WriteLine("{0} {1} age: {2} facultyNum: {3} phone: {4} email: {5} marks : {6}   group: {7}",
            //            students.FirstName, students.LastName, students.Age, students.FacultyNumber, students.Phone,
            //            students.Email, string.Join(", ", students.Marks), students.GroupNum);
            //}








            ////04   age in range 18 - 24 
            //Console.WriteLine();

            //var age = from student in myStudents
            //          where student.Age >= 18 && student.Age <= 24
            //          select new { student.FirstName, student.LastName, student.Age };

            //foreach (var stu  in age)
            //{
            //    Console.WriteLine("{0} {1} {2}", stu.FirstName, stu.LastName, stu.Age);
            //}







            /// problem 5 

            //var nameFirstLast = myStudents.OrderByDescending(name => name.FirstName)
            //.ThenByDescending(name => name.Age).Select(name => name);

            //foreach (var students in nameFirstLast)
            //{
            //    Console.WriteLine("{0} {1} age: {2} facultyNum: {3} phone: {4} email: {5} marks : {6}   group: {7}",
            //            students.FirstName, students.LastName, students.Age, students.FacultyNumber, students.Phone,
            //            students.Email, string.Join(", ", students.Marks), students.GroupNum);
            //}







            /// problem 6
            /// 

            //var stuByEmail = myStudents.Where(name => name.Email.Contains("abv.bg"));

            //foreach (var stu in stuByEmail)
            //{
            //    Console.WriteLine("{0} {1}", stu.FirstName, stu.Email);
            //}








            // problem 7

            //var stuByPhone = myStudents.Where(name => name.Phone.Contains("02 ") || 
            //    name.Phone.Contains("+3592") || name.Phone.Contains("+359 2"));
                

            //foreach (var phone in stuByPhone)
            //{
            //    Console.WriteLine("{0} {1}", phone.FirstName, phone.Phone);
            //}







            /// problem 8 
            /// 

            //var stuByMarkHigher = myStudents.Where(a => a.Marks.Contains(6))
            //    .Select(stu => new { Fullname = stu.FirstName + " " + stu.LastName, Exlentmark = stu.Marks});

            //foreach (var stu in stuByMarkHigher)
            //{
            //    Console.WriteLine("{0} {1}", stu.Fullname, string.Join(", ", stu.Exlentmark));
            //}







            /// problem 9 
            /// 

            //var stuByWeakMarks = myStudents.Where(stu => stu.Marks.Count(mark => mark == 2) == 2)
            //    .Select(stu => new {Fullname = stu.FirstName + " " + stu.LastName, Marks = stu.Marks });

            //foreach (var stu in stuByWeakMarks)
            //{
            //    Console.WriteLine("{0} {1}", stu.Fullname, string.Join(", ", stu.Marks));
            //}






            /// problem 10
            /// 

            //var stuByFacultynum = myStudents.Where(y => y.FacultyNumber.EndsWith("14"));

            //foreach (var stuByF in stuByFacultynum)
            //{
            //    Console.WriteLine("{0} {1} {2}", stuByF.FirstName, stuByF.FacultyNumber, string.Join(", ", stuByF.Marks.OrderBy(x => x)));
            //}




            /// problem 11
            /// 


            //var byGroupName = from stu in myStudents
            //                  group stu by stu.GroupName
            //                      into grupata
            //                      select grupata;

            //foreach (var stu in byGroupName)
            //{
            //    Console.WriteLine(stu.Key + " : ");
            //    foreach (var stud in stu)
            //    {
            //        Console.WriteLine("{0} {1} {2}", stud.FirstName, stud.LastName, stud.GroupName);       
            //    }
            //    Console.WriteLine();
            //}




            /// problem 12
            /// 

            var moreSpecialty = new List<StudentSpecialty>{
                new StudentSpecialty ("Web Developer", "203314"),
                new StudentSpecialty ("Web Developer", "203114"),
                new StudentSpecialty ("PHP Developer", "203814"),
                new StudentSpecialty ("PHP Developer", "203914"),
                new StudentSpecialty ("QA Developer", "203314"),
                new StudentSpecialty ("WEB Developer", "203914"),
            };

            var joinStudents = from firstStu in myStudents
                               from secondStu in moreSpecialty
                               where firstStu.FacultyNumber == secondStu.FacNum
                               orderby firstStu.FirstName
                               select new
                               {
                                   FName = firstStu.FirstName,
                                   SName = firstStu.LastName,
                                   FNum = firstStu.FacultyNumber,
                                   Specialty = secondStu.SpecialtyName
                               };
            foreach (var stu in joinStudents)
            {
                Console.WriteLine("{0} {1} {2} {3}",stu.FName,stu.SName,stu.FNum,stu.Specialty);
            }

            
            
            
   
        }
    }
}
