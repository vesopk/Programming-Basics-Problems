using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            var max = -1000000000000;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max) 
                {
                    max = num;
                }

            }
            Console.WriteLine(max);
        }
    }
}
