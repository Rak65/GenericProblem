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
            Console.WriteLine("Find Maximum Using Generic");

            int firstNumber = 90;
            int secondNumber = 110;
            int thirdNumber = 270;

            double fourNumber = 67.2;
            double fifthNumber = 80.56;
            double sixthNumber = 80.80;

            string firstName = "Max";
            string secondName = "Maximum";
            string thirdName = "StringValue";

            string value = FindMaximum<string>.MaximumValue(firstName, secondName, thirdName);
            Console.WriteLine(value);

            int Numvalue = FindMaximum<int>.MaximumValue(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(Numvalue);

            double Doublevalue = FindMaximum<double>.MaximumValue(fourNumber, fifthNumber, sixthNumber);
            Console.WriteLine(Doublevalue);
            Console .ReadKey();
        }
    }
}
