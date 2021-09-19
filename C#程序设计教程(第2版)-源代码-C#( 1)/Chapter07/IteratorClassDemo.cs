using System;using System.Collections;
namespace CSharpBook.Chapter7
{
    public class IteratorClassDemo
    {

        static void Main()
        {
            DaysOfTheWeek days = new DaysOfTheWeek();
            foreach (string d in days) Console.Write("{0} ", d);
            Console.ReadKey();
        }
    }
    public class DaysOfTheWeek : IEnumerable
    {
        private string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++) yield return days[i];
        }
    }
}
