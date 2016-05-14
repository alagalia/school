using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.IO;
using System.Text.RegularExpressions;
//using DocumentFormat.OpenXml;


namespace LINQtoExcel
{
    class linqToExcel
    {
        static void Main()
        {           
            List<SomeStudents> allStudents = new List<SomeStudents>();

            string path = "../../StudentsData.txt";
            StreamReader fileRead = new StreamReader(path);
           
            string spacePattern = @"\t";
            Regex regex = new Regex(spacePattern);
            
            using (fileRead)
            {
                string read = fileRead.ReadLine();
                bool forFirstTime = true;

                while (read != null)
                {
                    if (!forFirstTime)
                    {
                        string[] stuInfo = regex.Split(read);

                        double result = SomeStudents.CalculateResult(stuInfo[6], stuInfo[7], stuInfo[8], stuInfo[9],
                            stuInfo[10], stuInfo[11]);

                        allStudents.Add(new SomeStudents(stuInfo[0], stuInfo[1], stuInfo[2], stuInfo[3],
                            stuInfo[4], stuInfo[5], double.Parse(stuInfo[6]), double.Parse(stuInfo[7]),
                            double.Parse(stuInfo[8]), double.Parse(stuInfo[9]), double.Parse(stuInfo[10]),
                            double.Parse(stuInfo[11]),result));                        
                    }
                    else
                    {
                        forFirstTime = false;
                    }
                    read = fileRead.ReadLine();
                }
            }

            var onlineStudents = from student in allStudents
                                 where student.SType.Equals("Online")
                                 orderby student.Result descending
                                 select student;

            List<string> onlineStuToList = new List<string>();
            string support = string.Empty;
            
            foreach (var s in onlineStudents)
            {
                support = s.ID + "|" + s.FirstName + "|" + s.LastName + "|" + s.Email +
                    "|" + s.Gender + "|" + s.SType + "|" + s.ExamResult + "|" + s.HWSent +
                    "|" + s.HWEvaluted + "|" + s.TWScore + "|" + s.AttendancesCount +
                    "|" + s.Bonus + "|" + s.Result;
                onlineStuToList.Add(support);
                //Console.WriteLine(support);
            }


            var workBook = new XLWorkbook();
            var worksheet = workBook.Worksheets.Add("online students list");

            for (int col = 1; col <=13; col++)
            {
                string[] firstRow =  {"ID","First Name", "Last Name", "Email",
                                                  "Gender", "Student Type","Exam Result",
                                                  "Homework Sent", "Homework Evaluated",
                                                  "Teamwork Score", "Attendances Count",
                                                  "Bonus", "Result"};
                worksheet.Cell(1, col).Value = firstRow[col - 1];
            }

            int maxRow = onlineStuToList.Count();

            for (int row = 1; row <= maxRow; row++)
            {
                string[] details = onlineStuToList[row - 1].Split('|');

                for (int col = 1; col <= 13; col++)
                {
                    worksheet.Cell(row + 1, col).Value = details[col - 1];                    
                }
            }

            for (int i = 1; i <= 13; i++)
            {
                worksheet.Column(i).AdjustToContents();
            }
            workBook.SaveAs("../../studentTable.xlsx");           
        }
        
    }
}
