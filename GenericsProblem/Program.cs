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
            float num1 = 8.24F;
            float num2 = 58.24F;
            float num3 = 262.23F;
            Console .WriteLine ("Maximum number is "+ FindMaximum.MaxNumber(num1 ,num2 ,num3));
            Console.ReadKey();
        }
    }
}
