using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevidionWithoutLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            double devideBy2 = 0;
            double devideBy3 = 0;
            double devideBy4 = 0;
            for (int i = 0; i < numbersCount; i++) 
            {
                var number = double.Parse(Console.ReadLine());
                if (number % 2 == 0 && number % 3 == 0 && number % 4 ==0)
                {
                    devideBy2++;
                    devideBy3++;
                    devideBy4++;
                }
                else if (number % 2 == 0 && number % 3 == 0)
                {
                    devideBy2++;
                    devideBy3++;
                }
                else if (number % 2 == 0 && number % 4 == 0)
                {
                    devideBy2++;
                    devideBy4++;
                }
                else if (number % 3 == 0 && number % 4 == 0)
                {
                    devideBy3++;
                    devideBy4++;
                }
                else if (number % 4 == 0)
                {
                    devideBy4++;

                }
                else if (number % 3 == 0)
                {
                    devideBy3++;
                }
                else if (number % 2 == 0) 
                {
                    devideBy2++;
                }


            }
            Console.WriteLine("{0:f2}%", (devideBy2 / numbersCount) * 100);
            Console.WriteLine("{0:f2}%", (devideBy3 / numbersCount) * 100);
            Console.WriteLine("{0:f2}%", (devideBy4 / numbersCount) * 100);
        }
    }
}
