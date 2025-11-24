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
            int[] arr = { 4, 2, 7, 2, 9 };
            int target = 4;

            int index = Array.IndexOf(arr, target);

            Console.WriteLine("Індекс: " + index);
        }
    }
}
