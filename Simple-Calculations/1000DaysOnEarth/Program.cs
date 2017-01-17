using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysOnEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var format = "dd-MM-yyyy";
            var ourdate = DateTime.ParseExact(input, format, null);
            var result = ourdate.AddDays(999);
            Console.WriteLine(result.ToString(format));
        }
    }
}
