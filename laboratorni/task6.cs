using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task6
    {
        public static void SixthTask()
        {
            Console.Write("Введіть вік: ");
            double age = double.Parse(Console.ReadLine());

            if (age >= 12 && age <= 18)
            {
                Console.WriteLine("Підліток");
            }
            else
            {
                Console.WriteLine("Не підліток");
            }


        
        }
    }
}

