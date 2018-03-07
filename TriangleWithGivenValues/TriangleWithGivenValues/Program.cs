using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleWithGivenValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstAngle, secondAngle, thirdAngle;
            Console.WriteLine("Enter first angle");
            firstAngle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second angle");
            secondAngle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third angle");
            thirdAngle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The triangle with given angles is valid: " + isTriangleValid(firstAngle, secondAngle, thirdAngle));
            Console.ReadLine();
        }
        static bool isTriangleValid(int fn, int sn, int tn)
        {
            if (fn + sn + tn == 180)
                return true;
            else
                return false;
        }
    }
}
