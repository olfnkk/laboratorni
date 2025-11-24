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
            Console.Write("Введіть літеру: ");
            char ch = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (!char.IsLetter(ch))
            {
                Console.WriteLine("Це не літера.");
            }
            else if ("AEIOU".Contains(ch))
            {
                Console.WriteLine("Це голосна літера.");
            }
            else
            {
                Console.WriteLine("Це приголосна літера.");
            }
        }
    }
}
