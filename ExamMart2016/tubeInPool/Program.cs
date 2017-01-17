using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tubeInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            var volume = int.Parse(Console.ReadLine());
            var pipeOne = int.Parse(Console.ReadLine());
            var pipeTwo = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());
            var water = pipeOne * hours + pipeTwo * hours;
            if (water<=volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                        Math.Truncate(water / volume * 100),
                        Math.Truncate(pipeOne * hours / water * 100),
                        Math.Truncate(pipeTwo * hours / water * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, water - volume);
            }
        }
    }
}
