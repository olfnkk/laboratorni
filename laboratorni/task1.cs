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
            Console.WriteLine("Введіть число: ");

            double number = double.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Число додатнє");
            }
            else if (number < 0)
            {
                Console.WriteLine("Число від'ємне");
            }
            else
            {
                Console.WriteLine("Число дорівнює нулю");
            }
        }
    }
}
