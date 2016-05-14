using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoExcel
{
    public class SomeStudents
    {
        public SomeStudents(string id, string firstName, string lastName, string email,
            string gender, string studentType, double examResult, double homeworkSent,
            double homeworkEvaluted, double teamworkScore, double attendancesCount, double bonus,
            double result)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Gender = gender;
            this.SType = studentType;
            this.ExamResult = examResult;
            this.HWSent = homeworkSent;
            this.HWEvaluted = homeworkEvaluted;
            this.TWScore = teamworkScore;
            this.AttendancesCount = attendancesCount;
            this.Bonus = bonus;
            this.Result = result;

        }

        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string SType { get; set; }
        public double ExamResult { get; set; }
        public double HWSent { get; set; }
        public double HWEvaluted { get; set; }
        public double TWScore { get; set; }
        public double AttendancesCount { get; set; }
        public double Bonus { get; set; }
        public double Result { get; set; }

        public static double CalculateResult(string result,string result1,string result2,
            string result3,string result4,string result5)
        {
            double res = (double.Parse(result) + double.Parse(result1) + double.Parse(result2)+
                double.Parse(result3) + double.Parse(result4) + double.Parse(result5)) / 5;
            res = Math.Round(res,2);
            return res;
        }
    }
}
