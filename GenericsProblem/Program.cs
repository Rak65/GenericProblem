﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Using Generic");

            int intArray = GenericMaximum<int>.testMaximum(5, 6);
            double doubleArray = GenericMaximum<double>.testMaximum(1.1, 2.2);
            char charArray = GenericMaximum<char>.testMaximum('a', 'b');

            Console.WriteLine("Max value: " + intArray);
            Console.WriteLine("Max value: " + doubleArray);
            Console.WriteLine("Max value: " + charArray);
            Console .ReadKey();
        }
    }
}
