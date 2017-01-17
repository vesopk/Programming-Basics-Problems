using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double BGN = USD * 1.79549;
            double BGN2 = Math.Round(BGN, 2);
            Console.WriteLine("{0} BGN",BGN2);
        }
    }
}
