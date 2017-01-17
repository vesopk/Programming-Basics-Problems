using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());
            var allTimesInSeconds = time1 + time2 + time3;
            var timesInMin = allTimesInSeconds / 60;
            var timesInSec = allTimesInSeconds % 60;
            Console.WriteLine("{0}:{1:00}",timesInMin,timesInSec);
        }
    }
}
