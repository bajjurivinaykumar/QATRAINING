﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int multTable;
            Console.WriteLine("Enter a number to print multiplication table");
            multTable = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(multTable + " * " + i + " = " + multTable * i);
            }
            Console.ReadLine();
        }
    }
}
