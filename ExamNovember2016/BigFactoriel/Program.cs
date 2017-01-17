using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BigFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {

                int num = int.Parse(Console.ReadLine());
                BigInteger factorial = 1;
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
            }
        }
    }
}
