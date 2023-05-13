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
            int num1 = 860;
            int num2 = 30;
            int num3 = 60;
            Console .WriteLine ("Maximum number is "+ FindMaximum.MaxNumber(num1 ,num2 ,num3));
            Console.ReadKey();
        }
    }
}
