using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    class numToWord
    {
        public static string  numsToWord(int number)
        {
            
            if (number < 0 && number > 100)
            {
                return "invalid number";
            }
            return "fu";
        }

        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var exitWord = numsToWord(number);
            Console.WriteLine(exitWord);
        }
    }
}
