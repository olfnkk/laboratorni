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
            int limit = int.Parse(Console.ReadLine());

            int a = 1, b = 1;
            int sum = 0, count = 0;

            while (a < limit)
            {
                sum += a;
                count++;

                int next = a + b;
                a = b;
                b = next;
            }

            Console.WriteLine($"Сума = {sum}");
            Console.WriteLine($"Кількість елементів = {count}");
        }
    }
}
