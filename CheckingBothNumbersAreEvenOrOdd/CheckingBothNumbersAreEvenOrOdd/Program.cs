using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingBothNumbersAreEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            Console.WriteLine("Enter number 1");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are both Numbers entere Even or Odd: " + checkBothNumbersEvenOrOdd(firstNumber,secondNumber));
            Console.ReadLine();
        }
        static bool checkBothNumbersEvenOrOdd(int fn, int sn)
        {
            if ((fn % 2 == 0 && sn % 2 == 0) || (fn % 2 == 1 && sn % 2 == 1))
                return true;
            else
                return false;
        }

    }
   
}
