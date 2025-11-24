using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task2
    {
        public static void SecondTask()
        {
            Console.WriteLine("Введіть рік: ");

            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Рік високосний");
            }
            else
            {
                Console.WriteLine("Рік не високосний");
            }
        }
    }
}
