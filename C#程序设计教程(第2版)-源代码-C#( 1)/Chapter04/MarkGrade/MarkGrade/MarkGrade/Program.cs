using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark = 70; string grade;
            if (mark >= 90)
                grade = "优";
            else if (mark >= 80)
                grade = "良";
            else if (mark >= 70)
                grade = "中";
            else if (mark >= 60)
                grade = "及格";
            else
                grade = "不及格";
            Console.WriteLine(grade);

            if (mark >= 90)
                grade = "优";
            else if (mark >= 80 && mark < 90)
                grade = "良";
            else if (mark >= 70 && mark < 80)
                grade = "中";
            else if (mark >= 60 && mark < 70)
                grade = "及格";
            else
                grade = "不及格";
            Console.WriteLine(grade);

            if (mark >= 60)
                grade = "及格";
            else if (mark >= 70)
                grade = "中";
            else if (mark >= 80)
                grade = "良";
            else if (mark >= 90)
                grade = "优";
            else
                grade = "不及格";
            Console.WriteLine(grade);

            Console.ReadKey();

        }
    }
}
