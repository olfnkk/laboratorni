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
            ( int vowels, int consonants ) CountVowels(string text)
            {
                int vowels = 0;
                int consonants = 0;

                string vowelLetters = "aeiouAEIOUаеєиіїоуюяАЕЄИІЇОУЮЯ";


                foreach (char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        if (vowelLetters.Contains(c))
                            vowels++;
                        else
                            consonants++;
                    }
                }
                return (vowels, consonants);
            }
            Console.WriteLine(CountVowels("iytdsasdfgh"));
        }
    }
}
