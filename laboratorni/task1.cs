using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task1
    {
        public static void FirstTask()
        {
            double Calculate(double a, double b, char operation)
            {
                switch (operation)
                {
                    case '+':
                        return a + b;
                    case '-':
                        return a - b;
                    case '*':
                        return a * b;
                    case '/':
                        if (b != 0)
                            return a / b;
                        else
                        {
                            Console.WriteLine("Error: Division by zero");
                            return double.NaN;
                        }
                    default:
                        Console.WriteLine("Error: Invalid operation");
                        return double.NaN;
                }
            }
            Console.WriteLine(Calculate(10, 5, '+'));
            Console.WriteLine(Calculate(85, 3, '/'));
            Console.WriteLine(Calculate(10, 0, '/'));
            Console.WriteLine(Calculate(10, 5, '.'));
        }
    }
}


