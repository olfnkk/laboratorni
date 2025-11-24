using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task7
    {
        public static void SeventhTask()
        {
            Console.Write("Введіть число: ");
            double num = double.Parse(Console.ReadLine());

            if (num % 2 == 0 && num % 3 == 0)
            {
                Console.WriteLine("Число парне і ділиться на 3");
            }
            else if (num % 2 != 0 && num % 3 == 0)
            {
                Console.WriteLine("Число непарне і ділиться на 3");
            }
            else if (num % 2 == 0 && num % 3 != 0)
            {
                Console.WriteLine("Число парне і не ділиться на 3");
            }
            else
            {
                Console.WriteLine("Число непарне і не ділиться на 3");
            }

        }
    }
}
