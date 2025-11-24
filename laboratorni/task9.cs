using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task9
    {
        public static void ThirdTask_2_()
        {
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int n = matrix.GetLength(0);
            int[,] rotated = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotated[n - j - 1, i] = matrix[i, j];
                }
            }

            Console.WriteLine("Повернута матриця:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(rotated[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
