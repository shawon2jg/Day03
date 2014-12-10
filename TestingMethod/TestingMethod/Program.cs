using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a = 10;
            double result = GetSquare(a);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static double GetSquare(double aValue)
        {
            double squareValue = aValue*aValue;
            return squareValue;
        }
    }
}
