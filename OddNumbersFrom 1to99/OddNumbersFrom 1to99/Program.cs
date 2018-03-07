using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbersFrom_1to99
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers from 1 to 99 are as follows:");
            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + "\n");
                }
            }
            Console.ReadLine();
        }
    }
}
