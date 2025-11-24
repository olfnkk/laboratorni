using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task3
    {
        public static void ThirdTask()
        {
            Console.Write("Введіть число: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} × {i} = {n * i}");
            }
        }
    }
}
