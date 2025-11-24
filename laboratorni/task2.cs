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
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine("Сума = " + sum);
        }
        
    }
}
