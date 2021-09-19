using System;
namespace CSharpBook.Chapter15
{
    class CalendarTest
    {
        static void Main(string[] args)
        {
            const string s4 = "    ";          //空4格
            int nYear = DateTime.Today.Year;   //当前的年份
            int nMonth = DateTime.Today.Month; //当前的月份
            // 打印当年当月的日历
            DateTime d1 = new DateTime(nYear, nMonth, 1);
            Console.WriteLine("{0}/{1}", d1.Year, d1.Month);
            Console.WriteLine("SUN MON TUE WED THU FRI SAT");
            int iWeek = (int)d1.DayOfWeek; //获取当年当月1号的星期
            int iLastDay = d1.AddMonths(1).AddDays(-1).Day; //获取当年当月最后1天的日
            for (int i = 0; i < iWeek; i++) Console.Write(s4);
            for (int i = 1; i <= iLastDay; i++)//对应星期（Sun,Mon,…,Sat）打印日
            {  
                Console.Write(" {0:00} ", i);
                if ((i + iWeek) % 7 == 0) Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
