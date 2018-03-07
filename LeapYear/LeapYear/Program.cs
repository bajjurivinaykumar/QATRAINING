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
           
            int yearToCheck;
            Console.WriteLine("Enter year to check whether it is leap year or not");
            yearToCheck = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Is Leap Year: " + isLeapYear(yearToCheck));
            Console.ReadLine();
        }
        static bool isLeapYear(int year)
        {
            bool LeapYear = false;
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                LeapYear = true;
            }
            return LeapYear;
        }
    }
}
