using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task7
    {
        public static void FirstTask_2_()
        {
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
                sum += matrix[i, i];

            Console.WriteLine("Сума головної діагоналі: " + sum);
        }
    }
}
