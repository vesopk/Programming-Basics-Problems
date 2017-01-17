using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numsPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 0: Console.WriteLine("zero");break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                default:
                    Console.WriteLine("number too big");
                    break;
            }
        }
    }
}
