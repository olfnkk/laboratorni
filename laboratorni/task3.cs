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
            Console.Write("Введіть свій річний дохід (грн): ");
            double income = double.Parse(Console.ReadLine());

            double taxRate;

            if (income <= 100000)
            {
                taxRate = 0.05;
            }
            else if (income <= 300000)
            {
                taxRate = 0.10;
            }
            else if (income <= 1000000)
            {
                taxRate = 0.20;
            }
            else
            {
                taxRate = 0.30;
            }

            double tax = income * taxRate;

            Console.WriteLine($"\nСтавка податку: {taxRate * 100}%");
            Console.WriteLine($"Сума податку: {tax:F2} грн");
            Console.WriteLine($"До сплати залишається: {income - tax:F2} грн");
        }
    }
}
