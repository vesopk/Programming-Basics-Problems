using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersEnd = int.Parse(Console.ReadLine());

            for (int number = 1; number <= numbersEnd; number++)
            {
                int firstDigit = number / 10;
                int secondDigit = number % 10;
                int sum = firstDigit + secondDigit;
                if (sum==7 || sum == 5 || sum == 11)
                {
                    Console.WriteLine($"{number} -> True ");
                }
                else
                {
                    Console.WriteLine($"{number} -> False");
                }
                
            }
        }
    }
}
