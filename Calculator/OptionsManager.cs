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
        public static string Multiply(double a, double b)
        {
            return $"{a} * {b} = {a * b}";
        }
        public static string DevideReminder(double a, double b)
        {
            if (b==0)
            {
                throw new InvalidOperationException("Is not divisible by zero");
            }
            return $"{a} % {b} = {a % b}";
        }
        public static string Power(double a, double b)
        {
            return $"{a} ^ {b} = {Math.Pow(a,b)}";
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
        
        public static string SumSquareRoots(double a, double b)
        {
            if (a > 0 || b > 0)
            {
                return $"Square root of {a} + square root of {b} = {Math.Sqrt(a)+Math.Sqrt(b)}";
            }
            else
            {
                throw new InvalidOperationException("The numbers must be positive or 0");
            }
        }
        
        public static string SumSquares(double a, double b)
        {   
            return $"{a}^2 + {b}^2 = {Math.Pow(a,2)+ Math.Pow(b,2)}";
        }
    }
}
