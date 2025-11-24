using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task8
    {
        public static void EighthTask()
        {
            Console.Write("Введіть сторону a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введіть сторону b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введіть сторону c: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                double max = a;
                string longest = "a";

                if (b > max)
                {
                    max = b;
                    longest = "b";
                }

                if (c > max)
                {
                    max = c;
                    longest = "c";
                }

                Console.WriteLine($"Сторони утворюють трикутник.");
                Console.WriteLine($"Найдовша сторона: {longest} = {max}");
            }
            else
            {
                Console.WriteLine("Ці сторони НЕ утворюють трикутник.");
            }
        }
    }
}
