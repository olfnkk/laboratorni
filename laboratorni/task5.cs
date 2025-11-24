using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task5
    {
        public static void FifthTask()
        {
            Console.Write("Введіть три числа: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("Перше число найбільше ");
            }
            if (b > a && b > c)
            {
                Console.WriteLine("Друге число найбільше");
            }
            else
                Console.WriteLine("Третє число найбільше");

        }
    }
}
