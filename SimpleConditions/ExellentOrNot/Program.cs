using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExellentOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50 && grade <= 6.00)
            {
                Console.WriteLine("Excellent!");
            }
            else if (grade >= 2.00 && grade <= 5.49)
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
