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
            (int min, int max) FindMinMax(int[] numbers)
            {
                if (numbers == null || numbers.Length == 0)
                    throw new ArgumentException("Array cannot be null or empty.");
                int min = numbers[0];
                int max = numbers[0];
                foreach (int number in numbers)
                {
                    if (number < min) min = number;
                    if (number > max) max = number;
                }
                return (min, max);
            }
            Console.WriteLine(FindMinMax(new int[] { 3, 5, 1, 8, -2, 7 }));
            Console.WriteLine(FindMinMax(new int[] { 7, 52, 458, -254,  5, -55, 10, -2, 7 }));

        }
    }
}
