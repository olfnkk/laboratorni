using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task4
    {
        public static void FourthTask()
        {
            Console.Write("Введіть число: ");
            int n = int.Parse(Console.ReadLine());

            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Факторіал = " + factorial);
        }
    }
}
