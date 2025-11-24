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
            int[] arr = { -2, 3, -4, 5, -1 };

            int product = 1;
            bool hasNegatives = false;

            foreach (int x in arr)
            {
                if (x < 0)
                {
                    product *= x;
                    hasNegatives = true;
                }
            }

            if (hasNegatives)
                Console.WriteLine("Добуток від’ємних: " + product);
            else
                Console.WriteLine("Від’ємних елементів немає");
        }
    }
}
