using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class OptionsManager
    {
        public static string[] OptionsList =
        {
            "ex - Exit",
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "d - Devide",
            "sabs - SubtractAbs",
            "dr - DevideReminder",
            "pow - Power",
            "log - Logarithm",
            "min - Minimum",
            "max - Maximum",
            "avg - Average",
            "sqrt - SumSquareRoots",
            "sq - SumSquares"
        };

        public static string Add(double a, double b)
        {
            return $"{a} + {b} = {a + b}";
        }
        public static string Subtract(double a, double b)
        {
            return $"{a} - {b} = {a - b}";
        }

        public static string Divide(double a, double b)
        {
            if (b != 0)
            {
                 return $"{a} / {b} = {a / b}";
            }
            else
            {
                throw new InvalidOperationException("Not Divisible by zero");
            }
        }
        
        public static string SubstractAbs(double a, double b)
        {
            return $"|{a} - {b}| = {Math.Abs(a - b)}";
        }
    }
}
