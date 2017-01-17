using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPrints
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] array = new int[numbers];
            foreach (var arr in array)
            {
                Console.WriteLine(string.Join(",",arr));
            }
        }
    }
}
