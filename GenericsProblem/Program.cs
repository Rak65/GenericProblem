using System;
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
            string num1 = "50";
            string num2 = "70";
            string num3 = "85";
            Console .WriteLine ("Maximum number is "+ FindMaximum.MaxString (num1 ,num2 ,num3));
            Console.ReadKey();
        }
    }
}
