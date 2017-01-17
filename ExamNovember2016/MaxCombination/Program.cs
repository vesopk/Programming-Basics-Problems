using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int maxCombs = int.Parse(Console.ReadLine());

            var combosForNow = 0;

            for (int i = startingNum; i <=endNum; i++)
            {
                for (int k = startingNum; k <=endNum; k++)
                {
                    combosForNow++;
                    if (combosForNow<=maxCombs)
                    {
                        Console.Write("<{0}-{1}> ", i, k);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
