using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            if (number1<number2)
            {
                Console.WriteLine("Greather number:{0}",number2);
            }
            else
            {
                Console.WriteLine("Greather number:{0}",number1);
            }
        }
    }
}
