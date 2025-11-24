using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task8
    {
        public static void EighthTask()
        {
            int[,] matrix = {
                { 2, 3, 4 },
                { 5, 6, 7 },
                { 8, 9, 10 }
            };

            int column = 1; // другий стовпець

            int product = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                product *= matrix[i, column];
            }

            Console.WriteLine("Добуток стовпця: " + product);
        }
    }
}
