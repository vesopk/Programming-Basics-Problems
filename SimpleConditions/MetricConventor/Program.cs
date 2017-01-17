using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConventor
{
    class Program
    {
        static void Main(string[] args)
        {
            var convertNum = double.Parse(Console.ReadLine());
            var metricPoint1 = Console.ReadLine();
            var metricPoint2 = Console.ReadLine();
            Dictionary<string,double> curencies = new Dictionary<string, double>();
            {
                curencies.Add("mm",1000);
                curencies.Add("cm",100);
                curencies.Add("mi", 0.000621371192);
                curencies.Add("in", 39.3700787);
                curencies.Add("km", 0.001);
                curencies.Add("ft", 3.2808399);
                curencies.Add("yd", 1.0936133);
                curencies.Add("m",1);
            };
            double result = convertNum / curencies[metricPoint1] * curencies[metricPoint2];
            Console.WriteLine("{0} {1}",result,metricPoint2);
        }
    }
}
