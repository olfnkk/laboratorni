using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task1
    {
        public static void FirstTask()
        {
            int[] arr = { 5, 10, 15, 20 };

            double average = arr.Average();
            Console.WriteLine("Середнє: " + average);
        }
    }
}
