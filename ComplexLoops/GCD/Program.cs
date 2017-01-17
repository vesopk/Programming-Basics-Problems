using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var greather = Math.Max(a, b);
            var lesser = Math.Min(a, b);

            while (lesser != 0) 
            {
                var remainnder = greather % lesser;
                greather = lesser;
                remainnder = greather;

            }
            Console.WriteLine("GCD = {0}",lesser);
        }
    }
}
