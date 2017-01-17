using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComission
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var volumeOfSells = double.Parse(Console.ReadLine());
            double finalPrice = -1;

            if (city == "sofia")
            {
                if (volumeOfSells >= 0 && volumeOfSells <= 500)
                {
                    finalPrice = 0.0;
                    finalPrice = volumeOfSells * 0.05;
                    Console.WriteLine("{0:f2}", finalPrice);
                }
                else if (volumeOfSells > 500 && volumeOfSells <= 1000)
                {
                    finalPrice = 0.0;
                    finalPrice = volumeOfSells * 0.07;
                    Console.WriteLine("{0:f2}", finalPrice);
                }
                else if (volumeOfSells > 1000 && volumeOfSells <= 10000)
                {
                    finalPrice = 0.0;
                    finalPrice = volumeOfSells * 0.08;
                    Console.WriteLine("{0:f2}", finalPrice);
                }
                else if (volumeOfSells > 10000)
                {
                    finalPrice = 0.0;
                    finalPrice = volumeOfSells * 0.12;
                    Console.WriteLine("{0:f2}", finalPrice);
                }
            }

            else if (city == "varna") 
            {
                if (volumeOfSells >= 0 && volumeOfSells <= 500)
                {
                    finalPrice = 0.0;
                    finalPrice = volumeOfSells * 0.045;
                    Console.WriteLine("{0:f2}", finalPrice);
                }
                else if (volumeOfSells > 500 && volumeOfSells <= 1000)
                {
                    finalPrice = 0.0;
                    finalPrice = volumeOfSells * 0.075;
                    Console.WriteLine("{0:f2}", finalPrice);
                }
                else if (volumeOfSells > 1000 && volumeOfSells <= 10000)
                {
                    finalPrice = 0.0;
                    finalPrice = volumeOfSells * 0.10;
                    Console.WriteLine("{0:f2}", finalPrice);
                }
                else if (volumeOfSells > 10000)
                {
                    finalPrice = 0.0;
                    finalPrice = volumeOfSells * 0.13;
                    Console.WriteLine("{0:f2}", finalPrice);
                }
            }

            else if (city == "plovdiv")
            {
                if (volumeOfSells >= 0 && volumeOfSells <= 500)
                {
                    finalPrice = 0.0;
                    finalPrice = volumeOfSells * 0.055;
                    Console.WriteLine("{0:f2}", finalPrice);
                }
                else if (volumeOfSells > 500 && volumeOfSells <= 1000)
                {
                    finalPrice = 0.0;
                    finalPrice = volumeOfSells * 0.08;
                    Console.WriteLine("{0:f2}", finalPrice);
                }
                else if (volumeOfSells > 1000 && volumeOfSells <= 10000)
                {
                    finalPrice = 0.0;
                    finalPrice = volumeOfSells * 0.12;
                    Console.WriteLine("{0:f2}", finalPrice);
                }
                else if (volumeOfSells > 10000)
                {
                    finalPrice = 0.0;
                    finalPrice = volumeOfSells * 0.145;
                    Console.WriteLine("{0:f2}", finalPrice);
                }

            }
            else
            {
                Console.WriteLine("error");
            }
            if (finalPrice== -1)
            {
                Console.WriteLine("error");
            }
        }
    }
}
