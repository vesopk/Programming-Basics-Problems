using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbersCorrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersEnd = int.Parse(Console.ReadLine());
            int sum = 0;
            int firstDigit = 0;
            int secondDigit = 0;
            bool isSpecial = false;

            for (int number = 1; number <= numbersEnd; number++)
            {

                    firstDigit = number / 10;
                    secondDigit = number % 10;
                    sum = firstDigit + secondDigit;
                
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{number} -> {isSpecial}");

            }

        }
    }
}
