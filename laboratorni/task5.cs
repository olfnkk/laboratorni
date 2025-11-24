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
            bool IsPrime(int num)
            {
                if (num < 2) return false;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }

            int sum = 0;

            for (int i = 1; i <= 50; i++)
            {
                if (IsPrime(i))
                    sum += i;
            }

            Console.WriteLine("Сума простих чисел = " + sum);
        }
    }
}
