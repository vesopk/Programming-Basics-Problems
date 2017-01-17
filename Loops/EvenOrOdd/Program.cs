using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;
            if (numberOfNumbers == 0)
            {
                Console.WriteLine("yes sum 0");
            }
            for (int i = 0; i < numberOfNumbers; i++)
            {
                var element = int.Parse(Console.ReadLine());
                if (i % 2 == 0) 
                {
                    oddSum += element;

                }
                else
                {
                    evenSum += element;
                  
                }
                if (oddSum == evenSum)
                {
                    Console.WriteLine("yes sum {0}", evenSum);
                }
                else if (oddSum != evenSum)
                {
                    Console.WriteLine("no diff {0}", Math.Abs(evenSum - oddSum));
                }
                
            }
        }
    }
}
