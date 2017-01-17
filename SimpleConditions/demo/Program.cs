using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class NumberWord
    {
        static string[] one = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static string[] teens = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeeen", "eighteen", "nineteen" };
        static string[] ten = new string[] { null, null, "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        class Program
        {
            static void Main(string[] args)
            {

                int a = int.Parse(Console.ReadLine());
                if (a>100&&a<0)
                {
                    Console.WriteLine("Invalid number");
                }
                int hundreds = a / 100;
                int tens = (a / 10) % 10;
                int ones = a % 10;
                string wordRepresentation = "";

                if (hundreds == 0)
                {
                    if (tens == 0)
                    {
                        wordRepresentation = one[ones];
                    }
                    else
                    {
                        if (tens == 1)
                        {
                            wordRepresentation = teens[ones];
                        }
                        else
                        {
                            wordRepresentation = ten[tens];
                            if (ones > 0)
                            {
                                wordRepresentation += " " + one[ones];
                            }
                        }
                    }
                }
                else
                {
                    wordRepresentation = one[hundreds] + " hundred";
                    
                    
                }
                

                Console.WriteLine("{0}", wordRepresentation);

            }

        }
    }
}
