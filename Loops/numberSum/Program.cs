using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            var sum = 0.0;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum = sum + num;

            }
            Console.WriteLine("{0}",sum);
            
        }
    }
}
