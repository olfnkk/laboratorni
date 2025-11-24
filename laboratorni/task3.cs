using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task3
    {
        public static void ThirdTask()
        {
            int[] arr = { 3, 6, 9, 12, 15, 18 };

            foreach (int x in arr)
            {
                if (x % 2 == 0)
                    Console.Write(x + " ");
            }
        }
        
    }
}
