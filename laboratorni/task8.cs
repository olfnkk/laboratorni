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
            Console.Write("Введіть перше число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int b = int.Parse(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            Console.WriteLine("НСД = " + a);
        }
    }
}
