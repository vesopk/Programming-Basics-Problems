using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());
            var fieldArea = n * n;
            var platesArea = w * l;
            var benchArea = m * o;
            double platesNeeded = (fieldArea - benchArea) / platesArea;
            double timeNeeded = platesNeeded * 0.2;
            Console.WriteLine(platesNeeded);
            Console.WriteLine(timeNeeded);
        }
    }
}
