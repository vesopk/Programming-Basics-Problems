using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            double degree = (radian * 180) / Math.PI;
            double degreeNeeded = Math.Round(degree);
            Console.WriteLine(degreeNeeded);
        }
    }
}
