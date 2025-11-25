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
            double ConvertCurrency(double amount, double rate)
            {
                return amount * rate;
            }

            Console.WriteLine(ConvertCurrency(100, 1.1));
        }
    }
}
