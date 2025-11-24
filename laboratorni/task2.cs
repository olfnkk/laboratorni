using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task2
    {
        public static void SecondTask()
        {
            int[] arr = { 1, 2, 3, 2, 1 };

            bool isPalindrome = true;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrome ? "Паліндром" : "Не паліндром");
        }
    }
}
