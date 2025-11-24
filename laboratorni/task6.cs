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
            Console.Write("Введіть число: ");
            int n = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(n, 2);

            Console.WriteLine("У двійковій системі: " + binary);

        }
    }
}
