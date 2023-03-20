﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Console Calculator App");
                Console.WriteLine(new string('-', 15));

                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Choose one from the listed options:");
                foreach (string option in OptionsManager.OptionsList)
                {
                    Console.WriteLine($"\t{option}");
                }
                try
                {
                    Console.Write("Option: ");
                    string choice = Console.ReadLine();

                    if (choice == "ex")
                    {
                        break;
                    }
                    switch (choice)
                    {
                        case "a":
                            Console.WriteLine(OptionsManager.Add(a, b));
                            break;
                        case "m":
                            Console.WriteLine(OptionsManager.Multiply(a, b));
                            break;
                        case "dr":
                            Console.WriteLine(OptionsManager.DevideReminder(a, b));
                            
                            break;
                        case "pow":
                            Console.WriteLine(OptionsManager.Power(a, b));
                            break;

                        case "s":
                            Console.WriteLine(OptionsManager.Subtract(a, b));
                            break;
                        case "d":
                            Console.WriteLine(OptionsManager.Divide(a, b));
                            break;
                        case "sabs":
                            Console.WriteLine(OptionsManager.SubstractAbs(a, b));
                            break;
                        case "sqrt":
                            Console.WriteLine(OptionsManager.SumSquareRoots(a, b));
                            break;
                        case "sq":
                            Console.WriteLine(OptionsManager.SumSquares(a, b));
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
        }
    }
}
