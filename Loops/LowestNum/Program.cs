using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfNumbers = int.Parse(Console.ReadLine());
            var min = 1000000000000000000;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                var numbers = int.Parse(Console.ReadLine());
                if (numbers<min)
                {
                    min = numbers;
                }
            }
            Console.WriteLine(min);
        }
    }
}
