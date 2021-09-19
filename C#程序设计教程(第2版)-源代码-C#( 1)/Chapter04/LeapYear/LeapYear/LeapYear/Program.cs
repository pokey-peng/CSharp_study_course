using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2008;
            if (DateTime.IsLeapYear(year))
                Console.WriteLine("{0} year is a leap year!", year);
            else
                Console.WriteLine("{0} year is not a leap year!", year);


            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("{0} year is a leap year!", year);
            else
                Console.WriteLine("{0} year is not a leap year!", year);

            if (year % 400 == 0)
                Console.WriteLine("{0} year is a leap year!", year);
            else
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0) Console.WriteLine("{0} year is not a leap year!", year);
                    else Console.WriteLine("{0} year is a leap year!", year);
                }
                else
                    Console.WriteLine("{0} year is not a leap year!", year);
            }

            if (year % 400 == 0)
                Console.WriteLine("{0} year is a leap year!", year);
            else if (year % 4 != 0)
                Console.WriteLine("{0} year is not a leap year!", year);
            else if (year % 100 == 0)
                Console.WriteLine("{0} year is not a leap year!", year);
            else
                Console.WriteLine("{0} year is a leap year!", year);


            Console.ReadKey();
        }
    }
}
