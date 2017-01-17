using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(r,2);
            Console.WriteLine("{0:F12}",area);
        }
    }
}
