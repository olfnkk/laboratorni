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
            int[] arr = { -5, 7, 3, -2, 10, 25, -59, 2, 9 };

            int sum = 0;

            foreach (int x in arr)
            {
                if (x > 0)
                    sum += x;
            }

            Console.WriteLine("Сума додатних: " + sum);
        }
    }
}
